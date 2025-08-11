using Microsoft.AspNetCore.Mvc;
using arsTekstil.Persistence.Context;
using arsTekstil.Domain.Entities; // List<Customer> için gerekebilir
using System.Collections.Generic;
using System.Linq;

namespace arsTekstil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly arsTekstilDbContext _context;

        public CustomerController(arsTekstilDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();
            return Ok(customers);
        }
    }
}