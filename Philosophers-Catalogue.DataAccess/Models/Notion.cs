using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NodaTime;

namespace Philosophers_Catalogue.DataAccess.Models;

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
    public virtual ICollection<ItemBranch> Branches { get; set; } = new List<ItemBranch>();
    public virtual ICollection<ItemCategorySchool> CategoriesSchools { get; set; } = new List<ItemCategorySchool>();
    public virtual ICollection<ItemNotion> RelatedItems { get; set; } = new List<ItemNotion>(); // Works/Philosophers related to this notion
    public virtual ICollection<RelatedNotion> RelatedNotions { get; set; } = new List<RelatedNotion>();
}