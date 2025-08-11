using arsTekstil.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace arsTekstil.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> b)
    {
        b.HasKey(c => c.Id);
        b.Property(c => c.Name).IsRequired().HasMaxLength(120);
        b.HasIndex(c => c.Name).IsUnique(false);
    }
}