using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using arsTekstil.Persistence.Context;
using arsTekstil.Application.DTOs;
using arsTekstil.Domain.Entities;
using AutoMapper;
using System.Security.Cryptography;
using System.Text;

namespace arsTekstil.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly arsTekstilDbContext _context;
    private readonly IMapper _mapper;

    public CustomerController(arsTekstilDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/customer
    [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
        var customers = await _context.Customers
            .AsNoTracking()
            .ToListAsync();

        var dto = _mapper.Map<List<CustomerListDto>>(customers);
        return Ok(dto);
    }

    // POST: api/customer
    [HttpPost]
    public async Task<IActionResult> AddCustomer(CustomerCreateDto dto)
    {
        if (await _context.Customers.AnyAsync(c => c.Email == dto.Email))
            return BadRequest("Bu email zaten kayıtlı.");

        var customer = _mapper.Map<Customer>(dto);
        customer.PasswordHash = ComputeSha256Hash(dto.Password);

        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCustomers), new { id = customer.Id }, _mapper.Map<CustomerListDto>(customer));
    }

    // DELETE: api/customer/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCustomer(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
            return NotFound("Müşteri bulunamadı.");

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private static string ComputeSha256Hash(string rawData)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        var builder = new StringBuilder();
        foreach (var b in bytes)
            builder.Append(b.ToString("x2"));
        return builder.ToString();
    }
}
