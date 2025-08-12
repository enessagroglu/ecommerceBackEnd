namespace arsTekstil.Application.DTOs;

public class CustomerAddressDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string FullAddress { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}

public class CustomerAddressCreateDto
{
    public int CustomerId { get; set; }
    public string Title { get; set; } = "none";
    public string FullAddress { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}