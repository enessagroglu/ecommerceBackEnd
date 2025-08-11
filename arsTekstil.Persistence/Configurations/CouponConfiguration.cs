using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> b)
    {
        b.HasKey(c => c.Id);

        b.Property(c => c.Code).IsRequired().HasMaxLength(50);
        b.Property(c => c.DiscountAmount).HasColumnType("decimal(18,2)");
        b.Property(c => c.ExpiryDate).IsRequired();

        b.HasIndex(c => c.Code).IsUnique();
    }
}