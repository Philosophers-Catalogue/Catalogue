using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Philosophers_Catalogue.Models;

namespace Philosophers_Catalogue;

public class PhilosophersCatalogueDbContext(DbContextOptions<PhilosophersCatalogueDbContext> options)
    : IdentityDbContext<User, ApplicationRole, Guid>(options)
{
    public DbSet<Philosopher> Philosophers { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<CategorySchool> CategorySchools { get; set; }
    public DbSet<Notion> Notions { get; set; }
    public DbSet<Work> Works { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.EnableSensitiveDataLogging();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        base.OnModelCreating(builder);
    }
}