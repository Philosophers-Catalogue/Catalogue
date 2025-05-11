using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

public class Notion : IWikipediaItem
{
    public Guid NotionId { get; set; }

    public int? WikipediaId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = null!;

    [Required]
    [Column(TypeName = "text")]
    public string Description { get; set; } = null!;

    public Instant CreatedAt { get; set; }

    public Instant UpdatedAt { get; set; }

    // Navigation Properties
    public ICollection<CategorySchool> CategoriesSchools { get; set; } = null!;
    public ICollection<Work> RelatedItems { get; set; } = null!;
    public ICollection<RelatedNotion> RelatedNotions { get; set; } = null!;
}