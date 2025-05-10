using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace Philosophers_Catalogue.Models;

[Index(nameof(Name), IsUnique = true)]
public class Philosopher
{
    public Guid Id { get; set; }

    [MaxLength(255)]
    public required string Name { get; set; }
    
    public required string Bio { get; set; } 

    public LocalDate BirthDate { get; set; }
    public LocalDate DeathDate { get; set; }
    public bool IsFemale { get; set; }


    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    [Timestamp]
    [UsedImplicitly]
    public uint Version { get; set; }

    public ICollection<Branch> Branches { get; set; } = new List<Branch>();
    public ICollection<Work> Works { get; set; } = new List<Work>();
}