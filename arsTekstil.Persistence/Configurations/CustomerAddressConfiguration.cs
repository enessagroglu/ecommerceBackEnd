using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace arsTekstil.Persistence.Configurations;

public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> b)
    {
        b.HasKey(a => a.Id);

        b.Property(a => a.Title).HasMaxLength(60).HasDefaultValue("adres girilmedi");
        b.Property(a => a.FullAddress).IsRequired().HasMaxLength(1000);
        b.Property(a => a.ZipCode).HasMaxLength(20);

        b.HasOne(a => a.Customer)
            .WithMany(c => c.Addresses)
            .HasForeignKey(a => a.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}