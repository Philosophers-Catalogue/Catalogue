using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace Philosophers_Catalogue.Models;

public class User : IdentityUser<Guid>
{
    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    public ICollection<Interaction> Interactions { get; set; } = new List<Interaction>();
}