using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace Philosophers_Catalogue.Models;

[Index(nameof(Name), IsUnique = true)]
public class CategorySchool
{
    [Key]
    public Guid CategorySchoolId { get; set; }

    [MaxLength(150)]
    public required string Name { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? Description { get; set; }

    public Guid? ParentCategorySchoolId { get; set; }

    public Instant CreatedAt { get; set; }

    public Instant UpdatedAt { get; set; }

    [ForeignKey(nameof(ParentCategorySchoolId))]
    public CategorySchool? ParentCategorySchool { get; set; }

    public ICollection<CategorySchool> ChildCategoriesSchools { get; set; } = new List<CategorySchool>();
}