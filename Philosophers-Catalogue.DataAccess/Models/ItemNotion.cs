using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Philosophers_Catalogue.DataAccess.Models.Enums;

namespace Philosophers_Catalogue.DataAccess.Models;

[PrimaryKey(nameof(ItemId), nameof(NotionId))]
public class ItemNotion
{
    public Guid ItemId { get; set; }
    public ItemType ItemType { get; set; }

    public Guid NotionId { get; set; }

    [ForeignKey(nameof(NotionId))]
    public virtual Notion Notion { get; set; } = null!;
}