using NodaTime;

namespace Philosophers_Catalogue.DataAccess.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string PasswordHash { get; set; }
    public required string Email { get; set; }
    
    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }
    
    public virtual ICollection<Interaction> Interactions { get; set; } = new List<Interaction>();
}