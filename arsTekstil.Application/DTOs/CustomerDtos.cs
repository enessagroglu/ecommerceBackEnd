namespace arsTekstil.Application.DTOs;

// Liste ekranı için hafif DTO
public class CustomerListDto
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
}

// Detay ekranı için (adres sayısı vb. özet alanlar)
public class CustomerDetailDto
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public List<CustomerAddressDto> Addresses { get; set; } = new();
}

// Kayıt oluşturma – asla PasswordHash istemiyoruz, düz şifre alıp servis katmanında hashleyeceğiz
public class CustomerCreateDto
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!; // service hashleyecek
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
}

// Güncelleme – şifre zorunlu değil (boş gelirse değiştirmeyiz)
public class CustomerUpdateDto
{
    public string? Email { get; set; }
    public string? Password { get; set; } // null/empty ise password değişmez
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? ZipCode { get; set; }
    public string? PhoneNumber { get; set; }
}