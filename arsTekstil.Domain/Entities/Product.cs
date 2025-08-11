namespace arsTekstil.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Brand { get; set; } = null!;
    public string Size { get; set; } = null!;
    public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
    public double Point { get; set; }
    public int ReviewCount { get; set; }
    public string HighlightedFeatures { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int UnitsSold { get; set; }
    public double DiscountPercentage { get; set; }
    public int Stock { get; set; }
    public double TaxPercentage { get; set; }

    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();

    // Tersten gezebilmek için koleksiyon (opsiyonel ama faydalı)
    public ICollection<FavoriteProduct> FavoritedByCustomers { get; set; } = new List<FavoriteProduct>();
}
