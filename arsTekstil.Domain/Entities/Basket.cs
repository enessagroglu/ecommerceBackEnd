namespace arsTekstil.Domain.Entities;

public class Basket
{
    public Guid Id { get; set; } = Guid.NewGuid();

    // Guid yerine int olarak değiştirdik
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public ICollection<BasketItem> Items { get; set; } = new List<BasketItem>();
}