using Furniro.Domain.Aggregates;
using Furniro.Domain.Enteties;
using Microsoft.EntityFrameworkCore;

public class FurniroDbContext : DbContext
{
    public FurniroDbContext(DbContextOptions<FurniroDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasMany(o => o.Products);
    }
}