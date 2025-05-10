using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Philosophers_Catalogue.Models;

[PrimaryKey(nameof(NotionIdFrom), nameof(NotionIdTo))]
public class RelatedNotion
{
    public Guid NotionIdFrom { get; set; }

    public Guid NotionIdTo { get; set; }

    [MaxLength(50)]
    public string? RelationshipType { get; set; }

    [ForeignKey(nameof(NotionIdFrom))]
    public Notion NotionFrom { get; set; } = null!;

    [ForeignKey(nameof(NotionIdTo))]
    public Notion NotionTo { get; set; } = null!;
}