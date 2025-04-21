using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Philosophers_Catalogue.DataAccess.Models.Enums;

namespace Philosophers_Catalogue.DataAccess.Models;

[PrimaryKey(nameof(ItemId), nameof(BranchId))]
public class ItemBranch
{
        public Guid ItemId { get; set; }

        public ItemType ItemType { get; set; }

        public uint BranchId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; } = null!;
}