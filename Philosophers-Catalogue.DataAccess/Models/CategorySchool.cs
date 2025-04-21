using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace Philosophers_Catalogue.DataAccess.Models;

[Index(nameof(Name), IsUnique = true)]
public class CategorySchool
{
    [Key]
    public Guid CategorySchoolId { get; set; }

    [MaxLength(150)]
    public required string Name { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    [Column("parent_category_school_id")]
    public int? ParentCategorySchoolId { get; set; } // Nullable FK for hierarchy

    [Column("created_at")]
    public Instant CreatedAt { get; set; }

    [Column("updated_at")]
    public Instant UpdatedAt { get; set; }

    [ForeignKey(nameof(ParentCategorySchoolId))]
    public virtual CategorySchool? ParentCategorySchool { get; set; }
    public virtual ICollection<CategorySchool> ChildCategoriesSchools { get; set; } = new List<CategorySchool>();
    public virtual ICollection<ItemCategorySchool> RelatedItems { get; set; } = new List<ItemCategorySchool>();
}