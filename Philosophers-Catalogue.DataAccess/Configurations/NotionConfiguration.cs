using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.Data;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue.Configurations;

public class NotionConfiguration : IEntityTypeConfiguration<Notion>
{
    public void Configure(EntityTypeBuilder<Notion> builder)
    {
        builder.HasData(PhilosophySeedData.GetNotions());

        builder.HasMany(n => n.CategoriesSchools)
            .WithMany()
            .UsingEntity<Dictionary<string, object>>(
                "CategorySchoolNotion", // Name of the join table
                j => j.HasOne<CategorySchool>().WithMany().HasForeignKey("CategorySchoolsCategorySchoolId"),
                j => j.HasOne<Notion>().WithMany().HasForeignKey("NotionsNotionId"),
                j =>
                {
                    j.HasKey("NotionsNotionId", "CategorySchoolsCategorySchoolId");

                    j.HasData(
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.FormsId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PlatonismId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.CategoricalImperativeId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.KantianismId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.UbermenschId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        }, // Nietzsche is a precursor
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.DaseinId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.DaseinId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PhenomenologyId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.TabulaRasaId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.EmpiricismId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.CogitoErgoSumId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RationalismId
                        },
                        new
                        {
                            NotionsNotionId = PhilosophySeedData.SobornostId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        }
                    );
                });
    }
}