namespace arsTekstil.Domain.Entities;

public class FavoriteProduct
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    // İlerde işine yarayacak alanlar:
    public DateTime AddedAtUtc { get; set; } = DateTime.UtcNow;
}
