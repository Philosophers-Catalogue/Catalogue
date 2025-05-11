using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

public class Branch : IWikipediaItem
{
    public Guid Id { get; set; }

    public int? WikipediaId { get; set; }

    [MaxLength(128)]
    public required string Name { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    public ICollection<CategorySchool> CategorySchools { get; set; } = null!;
}