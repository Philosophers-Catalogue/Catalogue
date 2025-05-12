using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using Philosophers_Catalogue.Models.Abstract;

namespace Philosophers_Catalogue.Models;

[Index(nameof(NameEn), IsUnique = true)]
public class Philosopher : IWikipediaItem
{
    public Guid Id { get; set; }

    public int? WikipediaId { get; set; }

    [MaxLength(255)]
    public required string NameEn { get; set; }

    [MaxLength(255)]
    public required string NameRu { get; set; }

    public required string BioEn { get; set; }
    public required string BioRu { get; set; }

    public int BirthDate { get; set; }
    public int? DeathDate { get; set; }
    public bool IsFemale { get; set; }


    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    [Timestamp]
    [UsedImplicitly]
    public uint Version { get; set; }

    public ICollection<CategorySchool> CategorySchools { get; set; } = null!;
    public ICollection<Work> Works { get; set; } = null!;
}