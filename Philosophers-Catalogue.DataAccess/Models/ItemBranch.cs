using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Philosophers_Catalogue.Models.Enums;

namespace Philosophers_Catalogue.Models;

[PrimaryKey(nameof(ItemId), nameof(BranchId))]
public class ItemBranch
{
        public Guid ItemId { get; set; }

        public ItemType ItemType { get; set; }

        public Guid BranchId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; } = null!;
}