namespace arsTekstil.Domain.Entities;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}