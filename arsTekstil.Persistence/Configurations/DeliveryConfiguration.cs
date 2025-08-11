using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace arsTekstil.Persistence.Configurations;

public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> b)
    {
        b.HasKey(d => d.Id);

        b.Property(d => d.Status).HasMaxLength(50).HasDefaultValue("Hazırlanıyor");
        b.Property(d => d.TrackingNumber).HasMaxLength(100);

        b.HasIndex(d => d.TrackingNumber).IsUnique(false);

        b.HasOne(d => d.Customer)
            .WithMany(c => c.Deliveries)
            .HasForeignKey(d => d.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}