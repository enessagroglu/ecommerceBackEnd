namespace arsTekstil.Domain.Entities;

public class Delivery
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTime DeliveryDate { get; set; }
    public string Status { get; set; } = "Hazırlanıyor"; // örn: Gönderildi, Teslim Edildi
    public string TrackingNumber { get; set; } = null!;
}
