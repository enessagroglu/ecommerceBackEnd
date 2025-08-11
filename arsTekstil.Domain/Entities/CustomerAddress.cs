namespace arsTekstil.Domain.Entities;

public class CustomerAddress
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public string Title { get; set; } = "Varsayılan Adres"; // örn: Ev, Ofis
    public string FullAddress { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}
