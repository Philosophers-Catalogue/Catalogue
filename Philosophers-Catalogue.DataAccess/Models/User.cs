using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace Philosophers_Catalogue.Models;

[UsedImplicitly]
public class User : IdentityUser<Guid>
{
    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    public ICollection<Interaction> Interactions { get; set; } = null!;
}