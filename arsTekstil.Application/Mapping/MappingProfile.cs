using AutoMapper;
using arsTekstil.Application.DTOs;
using arsTekstil.Domain.Entities;

namespace arsTekstil.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Customer
        CreateMap<Customer, CustomerListDto>();
        CreateMap<Customer, CustomerDetailDto>();
        CreateMap<CustomerCreateDto, Customer>()
            .ForMember(d => d.PasswordHash, opt => opt.Ignore()); // hash serviste
        CreateMap<CustomerUpdateDto, Customer>()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

        // Address
        CreateMap<CustomerAddress, CustomerAddressDto>().ReverseMap();
        CreateMap<CustomerAddressCreateDto, CustomerAddress>();
        
        // Product
        CreateMap<Product, ProductListDto>();
        CreateMap<Product, ProductDetailDto>()
            .ForMember(d => d.Images, opt => opt.MapFrom(s => s.ProductImages))
            .ForMember(d => d.Categories, opt => opt.MapFrom(s => 
                s.ProductCategories.Select(pc => pc.Category)));

        CreateMap<ProductCreateDto, Product>()
            .ForMember(d => d.Point, opt => opt.MapFrom(_ => 0d))
            .ForMember(d => d.ReviewCount, opt => opt.MapFrom(_ => 0))
            .ForMember(d => d.UnitsSold, opt => opt.MapFrom(_ => 0));

        CreateMap<ProductUpdateDto, Product>()
            .ForAllMembers(opt => opt.Condition((src, dest, val) => val != null));

        
            // Basket / BasketItem
        CreateMap<Basket, BasketDto>()
            .ForMember(d => d.TotalAmount, opt => opt.Ignore()); // query tarafında hesapla

        CreateMap<BasketItem, BasketItemDto>()
            .ForMember(d => d.ProductName, opt => opt.MapFrom(s => s.Product.Name))
            .ForMember(d => d.UnitPrice,   opt => opt.MapFrom(s => s.Product.Price));
        
        // Order
        CreateMap<Order, OrderListDto>()
            .ForMember(d => d.ItemCount, opt => opt.MapFrom(s => s.Items.Count));

        CreateMap<Order, OrderDetailDto>();
        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(d => d.ProductName, opt => opt.MapFrom(s => s.Product.Name));
        
        // Delivery & Coupon
        CreateMap<Delivery, DeliveryDto>().ReverseMap();
        CreateMap<Coupon, CouponDto>().ReverseMap();

    }
}