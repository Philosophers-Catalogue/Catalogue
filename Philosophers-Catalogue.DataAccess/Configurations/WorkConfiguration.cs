using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.Data;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue.Configurations;

public class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.HasGeneratedTsVectorColumn(w => w.Embeddings,
                "english",
                work => new { Name = work.NameEn, work.DescriptionEn })
            .HasIndex(w => w.Embeddings)
            .HasMethod("GIN");

        builder
            .HasOne(w => w.PrimaryAuthor)
            .WithMany(p => p.Works)
            .HasForeignKey(w => w.PrimaryAuthorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(PhilosophySeedData.GetWorks());

        // Seed Work-CategorySchool relationships
        builder.HasMany(w => w.CategoriesSchools)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>(
                "CategorySchoolWork", // Name of the join table
                j => j.HasOne<CategorySchool>().WithMany().HasForeignKey("CategorySchoolsCategorySchoolId"),
                j => j.HasOne<Work>().WithMany().HasForeignKey("WorksId"),
                j =>
                {
                    j.HasKey("WorksId", "CategorySchoolsCategorySchoolId");

                    j.HasData(
                        new
                        {   
                            WorksId = PhilosophySeedData.RepublicId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PlatonismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.RepublicId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AncientGreekPhilosophyId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.NicomacheanEthicsId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AristotelianismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.CritiquePureReasonId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.KantianismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.CritiquePureReasonId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.GermanIdealismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.BeingAndNothingnessId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.SecondSexId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.FeminismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.SecondSexId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.MeditationsId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RationalismId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.DostoevskyPoeticsId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        }, // Bakhtin is complex
                        new
                        {
                            WorksId = PhilosophySeedData.GodmanhoodId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        },
                        new
                        {
                            WorksId = PhilosophySeedData.DisciplineAndPunishId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PostStructuralismId
                        }
                    );
                });
    }
}