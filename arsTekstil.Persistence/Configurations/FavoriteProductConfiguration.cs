using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct>
{
    public void Configure(EntityTypeBuilder<FavoriteProduct> b)
    {
        b.HasKey(fp => new { fp.CustomerId, fp.ProductId });

        b.Property(fp => fp.AddedAtUtc)
            .HasColumnType("datetime2")
            .HasDefaultValueSql("GETUTCDATE()");

        b.HasOne(fp => fp.Customer)
            .WithMany(c => c.FavoriteProducts)          // Customer tarafı ICollection<FavoriteProduct>
            .HasForeignKey(fp => fp.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        b.HasOne(fp => fp.Product)
            .WithMany(p => p.FavoritedByCustomers)      // Product tarafı ICollection<FavoriteProduct>
            .HasForeignKey(fp => fp.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        b.ToTable("FavoriteProducts");
    }
}