namespace arsTekstil.Application.DTOs;

public class BasketItemDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal UnitPrice { get; set; }   // projection ile Product.Price
    public int Quantity { get; set; }
}

public class BasketDto
{
    public Guid Id { get; set; }
    public int CustomerId { get; set; }
    public List<BasketItemDto> Items { get; set; } = new();
    public decimal TotalAmount { get; set; } // projection ile hesaplanacak
}

public class AddBasketItemDto
{
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; } = 1;
}

public class OrderItemDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class OrderListDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public int ItemCount { get; set; }
}

public class OrderDetailDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderItemDto> Items { get; set; } = new();
}

public class OrderCreateDto
{
    public int CustomerId { get; set; }
    public List<OrderCreateItemDto> Items { get; set; } = new();
}

public class OrderCreateItemDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}