using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> b)
    {
        b.HasKey(x => x.Id);

        b.HasIndex(x => x.CustomerId).IsUnique(); // 1 müşteri = 1 sepet

        b.HasMany(x => x.Items)
            .WithOne(i => i.Basket)
            .HasForeignKey(i => i.BasketId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}