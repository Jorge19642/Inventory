using Inventary.backend.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Inventary.backend.Data;

public class InventaryDBContext(DbContextOptions<InventaryDBContext> options) : DbContext(options)
{

    public DbSet<BrandName> BrandNames { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseConcept> PurchaseConcepts { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleConcept> SaleConcepts { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}