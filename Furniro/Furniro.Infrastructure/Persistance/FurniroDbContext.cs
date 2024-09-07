using Furniro.Domain.Aggregates;
using Furniro.Domain.Enteties;
using Furniro.Domain.ValueObjects;
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

        modelBuilder.Entity<Order>()
        .OwnsOne(o => o.Address, a =>
        {
            a.Property(a => a.City);
            a.Property(a => a.Country);
            a.Property(a => a.AddressLine);
            a.Property(a => a.PostalCode);
        });

        modelBuilder.Entity<Order>()
        .OwnsOne(o => o.Client, c =>
        {
            c.Property(c => c.FirstName);
            c.Property(c => c.LastName);
        });
    }
}