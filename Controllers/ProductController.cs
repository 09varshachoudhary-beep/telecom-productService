using Microsoft.AspNetCore.Mvc;
using ProductService.Data;
using Microsoft.EntityFrameworkCore;


namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly TelecomDbContext _context;

        public ProductController(TelecomDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        // Simple GET endpoint
        // [HttpGet]
        // public IActionResult GetProducts()
        // {
        //     var products = new[]
        //     {
        //         new { Id = 1, Name = "Laptop", Price = 800 },
        //         new { Id = 2, Name = "Smartphone", Price = 500 }
        //     };

        //     return Ok(products);
        // }

        // Health endpoint
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok(new { status = "Healthy", timestamp = DateTime.UtcNow });
        }
    }
}