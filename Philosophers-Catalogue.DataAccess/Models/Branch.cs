using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

public class Branch : IWikipediaItem
{
    public Guid Id { get; set; }

    public int? WikipediaId { get; set; }

    [MaxLength(128)]
    public required string NameEn { get; set; }

    [MaxLength(128)]
    public required string NameRu { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionEn { get; set; }

    [Column(TypeName = "text")]
    [SuppressMessage("ReSharper", "EntityFramework.ModelValidation.UnlimitedStringLength")]
    public string? DescriptionRu { get; set; }

    public ICollection<CategorySchool> CategorySchools { get; set; } = null!;
}