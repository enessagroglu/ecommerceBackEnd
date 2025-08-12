namespace arsTekstil.Application.DTOs;

public class DeliveryDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string Status { get; set; } = null!;
    public string TrackingNumber { get; set; } = null!;
}

public class CouponDto
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public decimal DiscountAmount { get; set; }
    public DateTime ExpiryDate { get; set; }
}

public class FavoriteProductAddDto
{
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
}