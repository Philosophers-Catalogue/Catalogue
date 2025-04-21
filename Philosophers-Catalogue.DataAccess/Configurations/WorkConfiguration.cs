using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.DataAccess.Models;

namespace Philosophers_Catalogue.DataAccess.Configurations;

public class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.HasGeneratedTsVectorColumn(w => w.Embeddings,
                "russian",
                work => new { work.Title, work.Description })
            .HasIndex(w => w.Embeddings)
            .HasMethod("GIN");
    }
}