namespace arsTekstil.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

    public Basket Basket { get; set; } = null!;
    public ICollection<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
    public ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();

    // ÖNEMLİ: Product değil, FavoriteProduct!
    public ICollection<FavoriteProduct> FavoriteProducts { get; set; } = new List<FavoriteProduct>();
}
