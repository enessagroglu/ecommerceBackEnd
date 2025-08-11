using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace arsTekstil.Persistence.Context;
public class arsTekstilDbContext : DbContext
{
    public arsTekstilDbContext(DbContextOptions<arsTekstilDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    public DbSet<FavoriteProduct> FavoriteProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(arsTekstilDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}
