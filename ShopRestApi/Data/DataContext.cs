using Microsoft.EntityFrameworkCore;
using ShopRestApi.Enteties;

namespace ShopRestApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }       

        public DbSet<Shop>? Shops { get; set; }

        public DbSet<ShopItem>? ShopItems { get; set; }

        public DbSet<Customer>? Customers { get; set; }
    }
}
