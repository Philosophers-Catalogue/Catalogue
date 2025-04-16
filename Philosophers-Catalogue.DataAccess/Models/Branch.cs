using System.ComponentModel.DataAnnotations;

namespace Philosophers_Catalogue.DataAccess.Models;

public class Branch
{
    public long Id { get; set; }
    
    [MaxLength(128)]
    public required string Name { get; set; }
    public string? Description { get; set; }

    public List<Philosopher> Philosophers { get; set; } = [];
}