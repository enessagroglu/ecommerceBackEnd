using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> b)
    {
        b.HasKey(c => c.Id);

        b.Property(c => c.Email).IsRequired().HasMaxLength(200);
        b.Property(c => c.PasswordHash).IsRequired().HasMaxLength(256);
        b.Property(c => c.Name).IsRequired().HasMaxLength(100);
        b.Property(c => c.Surname).IsRequired().HasMaxLength(100);
        b.Property(c => c.ZipCode).HasMaxLength(20);
        b.Property(c => c.PhoneNumber).HasMaxLength(30);

        b.HasIndex(c => c.Email).IsUnique();

        // 1-1 Basket
        b.HasOne(c => c.Basket)
            .WithOne(bk => bk.Customer)
            .HasForeignKey<Basket>(bk => bk.CustomerId);

        // Many-to-Many Customer <-> Coupon (skip navigation + join table)
        b.HasMany(c => c.Coupons)
            .WithMany(cp => cp.Customers)
            .UsingEntity(j => j.ToTable("CustomerCoupons"));
    } 
}