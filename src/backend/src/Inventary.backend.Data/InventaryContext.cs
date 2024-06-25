using Inventary.backend.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Inventary.backend.Data;

public class InventaryContext : DbContext 
{
    public DbSet<Product> Products { get; set; }
}
