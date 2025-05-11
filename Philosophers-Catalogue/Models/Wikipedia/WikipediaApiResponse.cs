using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace Philosophers_Catalogue.Models.Wikipedia;

[JsonSerializable(typeof(WikipediaCategoryMember))]
[PublicAPI]
public class WikipediaCategoryMember
{
    [JsonPropertyName("pageid")]
    public int PageId { get; set; }

    [JsonPropertyName("ns")]
    public int Ns { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

[JsonSerializable(typeof(QueryData))]
[PublicAPI]
public class QueryData
{
    [JsonPropertyName("categorymembers")]
    public required List<WikipediaCategoryMember> CategoryMembers { get; set; }
}

[JsonSerializable(typeof(WikipediaContinue))]
[PublicAPI]
public class WikipediaContinue
{
    [JsonPropertyName("cmcontinue")]
    public required string CmContinue { get; set; }

    [JsonPropertyName("continue")]
    public required string ContinueIndicator { get; set; }
}

[JsonSerializable(typeof(WikipediaApiResponse))]
[PublicAPI]
public class WikipediaApiResponse
{
    [JsonPropertyName("batchcomplete")]
    public bool BatchComplete { get; set; }

    [JsonPropertyName("continue")]
    public WikipediaContinue? Continue { get; set; }

    [JsonPropertyName("query")]
    public QueryData? Query { get; set; }
}