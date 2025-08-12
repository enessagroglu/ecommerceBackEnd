namespace arsTekstil.Application.DTOs;

public class ProductListDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Brand { get; set; } = null!;
    public double Point { get; set; }
    public int Stock { get; set; }
    public double DiscountPercentage { get; set; }
}

public class ProductImageDto
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public int DisplayOrder { get; set; }
}

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}

public class ProductDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Brand { get; set; } = null!;
    public string Size { get; set; } = null!;
    public double Point { get; set; }
    public int ReviewCount { get; set; }
    public string HighlightedFeatures { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int UnitsSold { get; set; }
    public double DiscountPercentage { get; set; }
    public int Stock { get; set; }
    public double TaxPercentage { get; set; }

    public List<ProductImageDto> Images { get; set; } = new();
    public List<CategoryDto> Categories { get; set; } = new();
}

// Create/Update
public class ProductCreateDto
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Brand { get; set; } = null!;
    public string Size { get; set; } = null!;
    public string HighlightedFeatures { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
    public double DiscountPercentage { get; set; }
    public double TaxPercentage { get; set; }

    // isteğe bağlı: ilk eklemede foto ve kategori
    public List<string>? ImageUrls { get; set; }
    public List<int>? CategoryIds { get; set; }
}

public class ProductUpdateDto
{
    public string? Name { get; set; }
    public decimal? Price { get; set; }
    public string? Brand { get; set; }
    public string? Size { get; set; }
    public string? HighlightedFeatures { get; set; }
    public string? Description { get; set; }
    public int? Stock { get; set; }
    public double? DiscountPercentage { get; set; }
    public double? TaxPercentage { get; set; }
}
