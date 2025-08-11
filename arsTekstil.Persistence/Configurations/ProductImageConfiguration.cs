using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace arsTekstil.Persistence.Configurations;

public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> b)
    {
        b.HasKey(pi => pi.Id);

        b.Property(pi => pi.ImageUrl).IsRequired().HasMaxLength(300);
        b.Property(pi => pi.DisplayOrder).HasDefaultValue(0);

        b.HasIndex(pi => new { pi.ProductId, pi.DisplayOrder });

        b.HasOne(pi => pi.Product)
            .WithMany(p => p.ProductImages)
            .HasForeignKey(pi => pi.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}