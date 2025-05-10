using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;

namespace Philosophers_Catalogue.Models;

public class Notion
{
    public Guid NotionId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = null!;

    [Required]
    [Column("description", TypeName = "text")]
    public string Description { get; set; } = null!;

    public Instant CreatedAt { get; set; }

    public Instant UpdatedAt { get; set; }

    // Navigation Properties
    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
    public virtual ICollection<CategorySchool> CategoriesSchools { get; set; } = new List<CategorySchool>();
    public virtual ICollection<Work> RelatedItems { get; set; } = new List<Work>(); 
    public virtual ICollection<RelatedNotion> RelatedNotions { get; set; } = new List<RelatedNotion>();
}