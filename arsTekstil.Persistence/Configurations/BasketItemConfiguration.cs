using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> b)
    {
        b.HasKey(i => i.Id);

        b.Property(i => i.Quantity).HasDefaultValue(1);

        // Sepette aynı üründen tek satır kuralı:
        b.HasIndex(i => new { i.BasketId, i.ProductId }).IsUnique();

        b.HasOne(i => i.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}