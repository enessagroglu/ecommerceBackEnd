using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> b)
    {
        b.HasKey(p => p.Id);

        b.Property(p => p.Name).IsRequired().HasMaxLength(200);
        b.Property(p => p.Brand).IsRequired().HasMaxLength(100);
        b.Property(p => p.Size).HasMaxLength(30);

        b.Property(p => p.Price).HasColumnType("decimal(18,2)");
        b.Property(p => p.DiscountPercentage).HasColumnType("decimal(5,2)").HasDefaultValue(0);
        b.Property(p => p.TaxPercentage).HasColumnType("decimal(5,2)").HasDefaultValue(0);
        b.Property(p => p.Point).HasColumnType("decimal(3,2)").HasDefaultValue(0);
        b.Property(p => p.ReviewCount).HasDefaultValue(0);
        b.Property(p => p.UnitsSold).HasDefaultValue(0);
        b.Property(p => p.Stock).HasDefaultValue(0);

        b.Property(p => p.HighlightedFeatures).HasMaxLength(2000);
        b.Property(p => p.Description).HasMaxLength(4000);

        b.HasIndex(p => p.Name);
        b.HasIndex(p => p.Brand);
    }
}