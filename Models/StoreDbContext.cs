using Microsoft.EntityFrameworkCore;
namespace Paradero_SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}
