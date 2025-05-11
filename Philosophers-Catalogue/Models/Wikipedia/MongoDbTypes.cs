using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Philosophers_Catalogue.Models.Wikipedia;

[UsedImplicitly]
public class WikipediaPageDetails
{
    [JsonPropertyName("pageid")]
    public int PageId { get; set; }

    [JsonPropertyName("ns")]
    public int Ns { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("extract")]
    public string? Extract { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("descriptionsource")]
    public string? DescriptionSource { get; set; }

    [JsonPropertyName("categories")]
    public List<WikipediaCategoryInfo>? Categories { get; set; }

    [JsonPropertyName("pageprops")]
    public WikipediaPageProps? PageProps { get; set; }
}

public class WikipediaCategoryInfo
{
    [JsonPropertyName("ns")]
    public int Ns { get; set; } // Не используется в данном контексте, но часть API

    [JsonPropertyName("title")]
    public string Title { get; set; } // e.g., "Категория:Философы по алфавиту"
}

public class WikipediaPageProps
{
    [JsonPropertyName("wikibase_item")]
    public string? WikibaseItemId { get; set; } // Wikidata ID, e.g., "Q937"
}

public class WikipediaQueryPagesData // Изменено имя для ясности
{
    [JsonPropertyName("pages")]
    public Dictionary<string, WikipediaPageDetails> Pages { get; set; } // Key is page ID as string
}

public class WikipediaQueryApiResponse // Для запроса деталей страниц
{
    [JsonPropertyName("batchcomplete")]
    public bool BatchComplete { get; set; }

    [JsonPropertyName("query")]
    public WikipediaQueryPagesData Query { get; set; } // Изменено имя свойства
}

// --- DTO для ответа Wikidata API ---
public class WikidataTimeValue
{
    [JsonPropertyName("time")]
    public string Time { get; set; } // e.g., "+1889-04-20T00:00:00Z"
    // Могут быть и другие поля: precision, timezone, calendarmodel
}

public class WikidataDataValue
{
    [JsonPropertyName("value")]
    public JsonElement Value { get; set; } // Может быть объектом (как WikidataTimeValue) или простой строкой

    [JsonPropertyName("type")]
    public string Type { get; set; } // "time", "string", "wikibase-entityid", etc.
}

public class WikidataSnak
{
    [JsonPropertyName("property")]
    public string Property { get; set; } // e.g., "P569" (date of birth)

    [JsonPropertyName("datavalue")]
    public WikidataDataValue DataValue { get; set; }

    [JsonPropertyName("snaktype")]
    public string SnakType { get; set; } // "value", "novalue", "somevalue"
}

public class WikidataClaim
{
    [JsonPropertyName("mainsnak")]
    public WikidataSnak MainSnak { get; set; }
    // Также rank, type, qualifiers, references
}

public class WikidataLanguageValue
{
    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}

public class WikidataEntity
{
    [JsonPropertyName("id")]
    public string Id { get; set; } // Wikidata Item ID, e.g., "Q937"

    [JsonPropertyName("claims")]
    public Dictionary<string, List<WikidataClaim>>? Claims { get; set; } // Ключ - ID свойства, e.g., "P569"

    [JsonPropertyName("labels")]
    public Dictionary<string, WikidataLanguageValue>? Labels { get; set; }

    [JsonPropertyName("descriptions")]
    public Dictionary<string, WikidataLanguageValue>? Descriptions { get; set; }
}

public class WikidataEntitiesApiResponse
{
    [JsonPropertyName("entities")]
    public Dictionary<string, WikidataEntity> Entities { get; set; } // Ключ - Wikidata Item ID

    [JsonPropertyName("success")]
    public int Success { get; set; } // Обычно 1 при успехе
}

// --- Модель документа для MongoDB ---
public class WikipediaPageDocument
{
    [BsonId] // Используем Wikipedia PageId как ID в MongoDB
    public int WikipediaPageId { get; set; }

    public string Title { get; set; }
    public string? Description { get; set; } // Краткое описание
    public string? Extract { get; set; } // Введение/аннотация
    public List<string>? Categories { get; set; } // Список названий категорий
    public string? WikidataId { get; set; }
    public DateTime? BirthDate { get; set; } // Дата рождения

    public DateTime? DeathDate { get; set; } // Дата смерти

    // Можно добавить другие поля, например, оригинальное название, ссылки на изображения и т.д.
    public DateTime LastUpdatedAt { get; set; } // Дата последнего обновления записи в MongoDB
}

// Класс для хранения PageId и Title, который вы уже используете
public class WikipediaPageQueryInfo(int pageId, string title)
{
    public int PageId { get; } = pageId;
    public string Title { get; } = title;
}

public class CategoryQueryData // Переименовал, чтобы избежать конфликта с QueryData для деталей
{
    [JsonPropertyName("categorymembers")]
    public List<WikipediaCategoryMember> CategoryMembers { get; set; }
}

public class CategoryApiResponse // Переименовал для ясности
{
    [JsonPropertyName("batchcomplete")]
    public bool BatchComplete { get; set; }

    [JsonPropertyName("continue")]
    public WikipediaContinue Continue { get; set; }

    [JsonPropertyName("query")]
    public CategoryQueryData Query { get; set; }
}