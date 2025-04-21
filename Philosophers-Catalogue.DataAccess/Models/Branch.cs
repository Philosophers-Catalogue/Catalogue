using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Philosophers_Catalogue.DataAccess.Models;

public class Branch
{
    public Guid Id { get; set; }
    
    [MaxLength(128)]
    public required string Name { get; set; }
    [Column(TypeName = "text")]
    public string? Description { get; set; }
    
    public virtual ICollection<ItemBranch> RelatedItems { get; set; } = new List<ItemBranch>();
}