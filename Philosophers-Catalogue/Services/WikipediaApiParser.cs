using System.Collections.Immutable;
using System.Text.Json;
using Philosophers_Catalogue.Constants;
using Philosophers_Catalogue.Models.Wikipedia;
using Quartz;

namespace Philosophers_Catalogue.Services;

public class WikipediaApiParser(IHttpClientFactory httpClientFactory, ILogger<WikipediaApiParser> logger) : IJob
{
    private sealed record WikipediaPageQueryInfo(int PageId, string PageTitle)
    {
        public int PageId { get; } = PageId;
        public string PageTitle { get; set; } = PageTitle;
    }

    private readonly List<WikipediaPageQueryInfo> wikipediaPageQueryInfoList = [];

    private static readonly ImmutableArray<string> Categories =
    [
        "Философы", "Философская_литература", "Философские_направления_и_школы",
        "Философские_термины", "Философские_теории",
        "Философские_фразы_и_выражения"
    ];

    public async Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation("WikipediaApiParser: Job Execution started.");

        await BuildInitialPageListAsync(context);

        if (wikipediaPageQueryInfoList.Count != 0)
            await FetchAndStorePageDetailsAsync(context);
    }

    private async Task BuildInitialPageListAsync(IJobExecutionContext context)
    {
        foreach (var initialCategoryName in Categories)
        {
            var categoriesToVisit = new Queue<(string CategoryTitle, int Depth)>();
            var visitedCategories = new HashSet<string>();

            var initialFullCategoryTitle = $"Категория:{initialCategoryName}";
            categoriesToVisit.Enqueue((initialFullCategoryTitle, 0));

            var httpClient = httpClientFactory.CreateClient(WikipediaConstants.RuWikiClientName);

            while (categoriesToVisit.Count > 0)
            {
                var (currentCategoryTitle, currentDepth) = categoriesToVisit.Dequeue();

                if (!visitedCategories.Add(currentCategoryTitle))
                    continue;

                if (currentDepth > 3) // depth restriction
                    continue;

                logger.LogInformation("Exploring category: {CurrentCategoryTitle} at depth {Depth}",
                    currentCategoryTitle, currentDepth);

                string? cmcontinueToken = null;

                do
                {
                    var requestUrl =
                        $"?action=query&format=json&list=categorymembers&cmtitle={Uri.EscapeDataString(currentCategoryTitle)}&cmlimit=500&formatversion=2";

                    if (!string.IsNullOrEmpty(cmcontinueToken))
                        requestUrl += $"&cmcontinue={Uri.EscapeDataString(cmcontinueToken)}";

                    string responseJson;

                    try
                    {
                        await Task.Delay(200, context.CancellationToken); // delay
                        responseJson = await httpClient.GetStringAsync(requestUrl, context.CancellationToken);
                    }
                    catch (HttpRequestException ex)
                    {
                        logger.LogError(ex, "Error fetching data for category {CurrentCategoryTitle}: {Message}",
                            currentCategoryTitle, ex.Message);

                        break;
                    }

                    WikipediaApiResponse? apiResponse;

                    try
                    {
                        apiResponse = JsonSerializer.Deserialize<WikipediaApiResponse>(responseJson);
                    }
                    catch (JsonException ex)
                    {
                        logger.LogError(ex, "Error deserializing JSON for category {CurrentCategoryTitle}: {ExMessage}",
                            currentCategoryTitle, ex.Message);

                        apiResponse = null;
                    }

                    if (apiResponse?.Query?.CategoryMembers != null)
                        foreach (var member in apiResponse.Query.CategoryMembers)
                            if (member.Ns == 0) // regular page
                                wikipediaPageQueryInfoList.Add(new WikipediaPageQueryInfo(member.PageId, member.Title));
                            else if (member.Ns == 14 && !member.Title.Contains("Философы") &&
                                     !visitedCategories.Contains(member.Title) &&
                                     currentDepth < 3)
                                categoriesToVisit.Enqueue((member.Title, currentDepth + 1));

                    cmcontinueToken = apiResponse?.Continue?.CmContinue;
                } while (!string.IsNullOrEmpty(cmcontinueToken));
            }
        }
    }

    private async Task FetchAndStorePageDetailsAsync(IJobExecutionContext context)
    {
        logger.LogInformation("Starting to fetch details for {Count} pages.", wikipediaPageQueryInfoList.Count);

        const int batchSize = 40; // API Википедии обычно позволяет до 50 pageids/titles за раз. Возьмем чуть меньше.

        for (var i = 0; i < wikipediaPageQueryInfoList.Count; i += batchSize)
        {
            if (context.CancellationToken.IsCancellationRequested)
            {
                logger.LogInformation("Cancellation requested, stopping page detail fetching.");

                break;
            }

            var batchPageInfos = wikipediaPageQueryInfoList.Skip(i).Take(batchSize).ToList();

            if (batchPageInfos.Count == 0) continue;

            var pageIdsToQuery = string.Join("|", batchPageInfos.Select(p => p.PageId));

            logger.LogInformation(
                "Fetching Wikipedia details for batch of {BatchCount} pages, starting with ID {FirstPageId}",
                batchPageInfos.Count, batchPageInfos[0].PageId);

            // 1. Получаем основную информацию из Википедии
            var wikiApiUrl = $"?action=query&format=json&pageids={pageIdsToQuery}" +
                             "&prop=extracts|categories|pageprops|description&formatversion=2" +
                             "&exintro=true&explaintext=true&cllimit=max&ppprop=wikibase_item";

            var wikipediaHttpClient = httpClientFactory.CreateClient(WikipediaConstants.RuWikiClientName);

            WikipediaQueryApiResponse? wikiQueryResponse = null; // Используем новый DTO

            try
            {
                await Task.Delay(250, context.CancellationToken);
                var jsonResponse = await wikipediaHttpClient.GetStringAsync(wikiApiUrl, context.CancellationToken);
                wikiQueryResponse = JsonSerializer.Deserialize<WikipediaQueryApiResponse>(jsonResponse);
            }
            catch (Exception ex) when (ex is HttpRequestException or JsonException or TaskCanceledException)
            {
                logger.LogError(ex,
                    "Error fetching/parsing Wikipedia batch details for page IDs starting with {FirstPageId}.",
                    batchPageInfos[0].PageId);

                if (ex is TaskCanceledException) return;

                continue;
            }

            if (wikiQueryResponse?.Query?.Pages == null)
            {
                logger.LogWarning("No page data from Wikipedia for batch starting with ID {FirstPageId}.",
                    batchPageInfos[0].PageId);

                continue;
            }

            var currentBatchDocuments = new List<WikipediaPageDocument>();
            var wikidataIdsToFetch = new List<string>();
            // Временный словарь для легкого доступа к документам по Wikidata ID при обновлении
            var docsByWikidataId = new Dictionary<string, WikipediaPageDocument>();

            foreach (var doc in wikiQueryResponse.Query.Pages
                         .Select(pageDataEntry => pageDataEntry.Value)
                         .Select(pageDetail => new WikipediaPageDocument
                         {
                             WikipediaPageId = pageDetail.PageId,
                             Title = pageDetail.Title,
                             Description = pageDetail.Description,
                             Extract = pageDetail.Extract,
                             Categories = pageDetail.Categories?.Select(c => c.Title).ToList() ?? [],
                             WikidataId = pageDetail.PageProps?.WikibaseItemId,
                             LastUpdatedAt = DateTime.UtcNow
                         }))
            {
                currentBatchDocuments.Add(doc);

                if (!string.IsNullOrEmpty(doc.WikidataId))
                {
                    wikidataIdsToFetch.Add(doc.WikidataId);
                    docsByWikidataId[doc.WikidataId] = doc; // Сохраняем ссылку на документ
                }
            }

            // 2. Получаем детали из Викиданных, если есть ID
            if (wikidataIdsToFetch.Count != 0)
                // Викиданные также поддерживают пакетную обработку, до 50 ID
                for (var j = 0; j < wikidataIdsToFetch.Count; j += batchSize) // Можно использовать тот же batchSize
                {
                    if (context.CancellationToken.IsCancellationRequested) break;

                    var wikidataBatchIds = wikidataIdsToFetch.Skip(j).Take(batchSize).ToList();

                    if (wikidataBatchIds.Count == 0) continue;

                    var wikidataIdsParam = string.Join("|", wikidataBatchIds);

                    logger.LogInformation("Fetching details from Wikidata for {Count} items, starting with {FirstWdId}",
                        wikidataBatchIds.Count, wikidataBatchIds[0]);

                    // Важно: URL для Викиданных отличается!
                    var wikidataHttpClient = httpClientFactory.CreateClient(WikipediaConstants.WikiDataClientName);

                    var wikidataApiUrl =
                        $"?action=wbgetentities&ids={wikidataIdsParam}&props=claims|labels|descriptions&languages=ru&format=json&formatversion=2";

                    WikidataEntitiesApiResponse? wdEntitiesResponse = null;

                    try
                    {
                        await Task.Delay(250, context.CancellationToken);

                        var wdJsonResponse =
                            await wikidataHttpClient.GetStringAsync(wikidataApiUrl, context.CancellationToken);

                        // ReSharper disable once RedundantAssignment
                        wdEntitiesResponse = JsonSerializer.Deserialize<WikidataEntitiesApiResponse>(wdJsonResponse);
                    }
                    catch (Exception ex) when (ex is HttpRequestException or JsonException or TaskCanceledException)
                    {
                        logger.LogError(ex,
                            "Error fetching/parsing Wikidata batch details for IDs starting with {FirstWdId}.",
                            wikidataBatchIds[0]);

                        if (ex is TaskCanceledException)
                        {
                            /* outer loop will break */
                        } // Позволяем внешнему циклу прерваться
                        else
                        {
                            continue;
                        } // Пропустить этот пакет Викиданных
                    }

                    if (context.CancellationToken.IsCancellationRequested) break;
                } // конец цикла по пакетам Викиданных

            if (context.CancellationToken.IsCancellationRequested) break;
        }

        logger.LogInformation("Finished fetching and storing all page details.");
    }

    // Вспомогательный метод для парсинга дат из Викиданных
}