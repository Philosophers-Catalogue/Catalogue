using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

[Index(nameof(Name), IsUnique = true)]
[PublicAPI]
public class CategorySchool : IWikipediaItem
{
    [Key]
    public Guid CategorySchoolId { get; set; }

    public int? WikipediaId { get; set; }

    [MaxLength(150)]
    public required string Name { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? Description { get; set; }

    public Guid? ParentCategorySchoolId { get; set; }
    public Guid BranchId { get; set; }

    public Instant CreatedAt { get; set; }

    public Instant UpdatedAt { get; set; }

    [ForeignKey(nameof(ParentCategorySchoolId))]    
    public CategorySchool? ParentCategorySchool { get; set; }

    public ICollection<CategorySchool> ChildCategoriesSchools { get; set; } = null!;
    public Branch Branch { get; set; } = null!;
}