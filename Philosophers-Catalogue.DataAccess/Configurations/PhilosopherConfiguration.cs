using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Philosophers_Catalogue.Data;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue.Configurations;

public class PhilosopherConfiguration : IEntityTypeConfiguration<Philosopher>
{
    public void Configure(EntityTypeBuilder<Philosopher> builder)
    {
        builder.HasMany(p => p.CategorySchools)
            .WithMany() // This defines the relationship structure
            .UsingEntity<Dictionary<string, object>>(
                "CategorySchoolPhilosopher",
                j => j.HasOne<CategorySchool>().WithMany().HasForeignKey("CategorySchoolsCategorySchoolId"),
                j => j.HasOne<Philosopher>().WithMany().HasForeignKey("PhilosophersId"),
                j =>
                {
                    j.HasKey("PhilosophersId", "CategorySchoolsCategorySchoolId"); // Define composite key

                    j.HasData(
                        new
                        {
                            PhilosophersId = PhilosophySeedData.PlatoId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PlatonismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.PlatoId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AncientGreekPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.AristotleId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AristotelianismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.AristotleId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AncientGreekPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.AristotleId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RealismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.KantId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.KantianismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.KantId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.GermanIdealismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.NietzscheId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        }, // Loosely, precursor
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SartreId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SartreId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PhenomenologyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SartreId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ContinentalPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.DeBeauvoirId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.DeBeauvoirId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.FeminismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.DeBeauvoirId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ContinentalPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.DescartesId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RationalismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.DescartesId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ModernPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.LockeId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.EmpiricismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.LockeId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ModernPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.HumeId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.EmpiricismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.HumeId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ModernPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SpinozaId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RationalismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SpinozaId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ModernPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.WittgensteinId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.AnalyticPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.WittgensteinId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.LogicalPositivismId
                        }, // Early Wittgenstein
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SolovyovId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.SolovyovId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.IdealismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.BerdyaevId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.BerdyaevId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        }, // Christian Existentialism
                        new
                        {
                            PhilosophersId = PhilosophySeedData.ShestovId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.ShestovId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ExistentialismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.LosevId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.RussianReligiousPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.LosevId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.IdealismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.ArendtId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ContinentalPhilosophyId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.FoucaultId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.PostStructuralismId
                        },
                        new
                        {
                            PhilosophersId = PhilosophySeedData.FoucaultId,
                            CategorySchoolsCategorySchoolId = PhilosophySeedData.ContinentalPhilosophyId
                        }
                    );
                });

        builder.HasData(PhilosophySeedData.GetPhilosophers());
    }
}