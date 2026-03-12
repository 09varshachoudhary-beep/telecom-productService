using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Data
{
    public class TelecomDbContext : DbContext
    {
        public TelecomDbContext(DbContextOptions<TelecomDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}