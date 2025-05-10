using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue.Configurations;

public class RelatedNotionConfiguration : IEntityTypeConfiguration<RelatedNotion>
{
    public void Configure(EntityTypeBuilder<RelatedNotion> builder)
    {
        builder.HasOne(rn => rn.NotionFrom)
            .WithMany(n => n.RelatedNotions)
            .HasForeignKey(rn => rn.NotionIdFrom)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(rn => rn.NotionTo)
            .WithMany()
            .HasForeignKey(rn => rn.NotionIdTo)
            .OnDelete(DeleteBehavior.Restrict);
    }
}