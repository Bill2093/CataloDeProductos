using Microsoft.EntityFrameworkCore;
using CataloDeProductos.Models;

namespace CataloDeProductos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
