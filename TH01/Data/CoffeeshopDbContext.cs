using Microsoft.EntityFrameworkCore;
using TH01.Models;

namespace TH01.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
