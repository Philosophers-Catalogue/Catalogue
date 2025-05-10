using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue.Configurations;

public class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.HasGeneratedTsVectorColumn(w => w.Embeddings,
                "russian",
                work => new { work.Title, work.Description })
            .HasIndex(w => w.Embeddings)
            .HasMethod("GIN");

        builder
            .HasOne(w => w.PrimaryAuthor)
            .WithMany(p => p.Works)
            .HasForeignKey(w => w.PrimaryAuthorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}