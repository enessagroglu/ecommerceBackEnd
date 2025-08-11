namespace arsTekstil.Domain.Entities;

public class ProductImage
{
    public int Id { get; set; } // Identity (auto increment)

    public int ProductId { get; set; } // Foreign Key
    public Product Product { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public int DisplayOrder { get; set; } // Görselin sırası (opsiyonel)
}
