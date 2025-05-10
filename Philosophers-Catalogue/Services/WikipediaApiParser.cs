using System.Collections.Immutable;
using Quartz;

namespace Philosophers_Catalogue.Services;

public class WikipediaApiParser(HttpClient httpClient) : IJob
{
    private static readonly ImmutableArray<string> Categories =
    [
        "Философы",
        "Философская_литература",
        "Философские_направления_и_школы",
        "Философские_термины",
        "Философские_теории",
        "Философские_фразы_и_выражения"
    ];

    public async Task Execute(IJobExecutionContext context)
    {
        foreach (var category in Categories)
        {
            var response =
                await httpClient.GetStringAsync(
                    $"?action=query&format=json&list=categorymembers&cmtitle=Категория:{category}&cmlimit=500");

            await File.WriteAllTextAsync(AppContext.BaseDirectory + $"\\{category}.txt", response);
        }
        throw new NotImplementedException();
    }
}