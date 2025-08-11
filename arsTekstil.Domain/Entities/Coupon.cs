namespace arsTekstil.Domain.Entities;

public class Coupon
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiryDate { get; set; }

    public ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
