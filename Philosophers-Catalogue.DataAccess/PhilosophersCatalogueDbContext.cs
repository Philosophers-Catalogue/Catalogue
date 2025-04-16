using Philosophers_Catalogue.DataAccess.Models;

namespace Philosophers_Catalogue.DataAccess;

using Microsoft.EntityFrameworkCore;

public class PhilosophersCatalogueDbContext(DbContextOptions<PhilosophersCatalogueDbContext> options)
    : DbContext(options)
{
    public DbSet<Philosopher> Philosophers { get; set; }
    public DbSet<Branch> Branches { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}