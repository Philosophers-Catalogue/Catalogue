using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using NodaTime;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

public class Notion : IWikipediaItem
{
    public Guid NotionId { get; set; }

    public int? WikipediaId { get; set; }

    [Required]
    [MaxLength(255)]
    public string NameRu { get; set; } = null!;

    [Required]
    [MaxLength(255)]
    public string NameEn { get; set; } = null!;

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionEn { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionRu { get; set; }

    public Instant CreatedAt { get; set; }

    public Instant UpdatedAt { get; set; }

    // Navigation Properties
    public ICollection<CategorySchool> CategoriesSchools { get; set; } = null!;
    public ICollection<Work> RelatedItems { get; set; } = null!;
    public ICollection<RelatedNotion> RelatedNotions { get; set; } = null!;
}