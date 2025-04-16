using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace Philosophers_Catalogue.DataAccess.Models;

public class Philosopher
{
    public long Id { get; set; }

    [MaxLength(128)]
    public required string Name { get; set; }

    public DateTime BirthDate { get; set; }
    public DateTime DeathDate { get; set; }
    public bool IsFemale { get; set; }

    public List<Branch> Branches { get; set; } = [];

    [Timestamp]
    [UsedImplicitly]
    public required byte[] Version { get; set; }
}