using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using Philosophers_Catalogue.DataAccess.Models.Enums;

namespace Philosophers_Catalogue.DataAccess.Models;

[Index(nameof(UserId))]
[Index(nameof(ItemId))]
[Index(nameof(ItemType))]
[Index(nameof(InteractionTimestamp))]
public class Interaction
{
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required]
        public ItemType ItemType { get; set; }

        [Required]
        public InteractionType InteractionType { get; set; }

        public short? RatingValue { get; set; }
        public Instant InteractionTimestamp { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
}