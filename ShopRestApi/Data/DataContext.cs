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

        public DbSet<Toy>? Toys { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        public DbSet<ShopOwnerShop>? ShopOwnerShops { get; set; }

        public List<Shop> GetShop()
        {
            return Shops.Include(s => s.ShopOwnersShop).ThenInclude(so => so.ShopOwner).ToList();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>()
                .HasMany(s => s.ShopItems)
                .WithOne(si => si.Shop)
                .HasForeignKey(si => si.ShopId);

            modelBuilder.Entity<ShopOwnerShop>()
                .HasKey(bc => new { bc.ShopId, bc.ShopOwnerId });

            modelBuilder.Entity<ShopOwnerShop>()
                .HasOne(s => s.ShopOwner)
                .WithMany(so => so.Shops)
                .HasForeignKey(s => s.ShopOwnerId);

            modelBuilder.Entity<ShopOwnerShop>()
               .HasOne(s => s.Shop)
               .WithMany(so => so.ShopOwnersShop)
               .HasForeignKey(s => s.ShopId);
            //modelBuilder.Entity<Shop>()
            //    .HasMany(s => s.ShopOwners)
            //    .WithOne()
            //    .HasForeignKey(so => so.SingleShopId);
        }
    }
}
