using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Philosophers_Catalogue.DataAccess.Models.Enums;

namespace Philosophers_Catalogue.DataAccess.Models;

[PrimaryKey(nameof(ItemId), nameof(CategoryId))]
public class ItemCategorySchool
{
    public Guid ItemId { get; set; }

    public ItemType ItemType { get; set; }

    public uint CategoryId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public CategorySchool CategorySchool { get; set; } = null!;
}