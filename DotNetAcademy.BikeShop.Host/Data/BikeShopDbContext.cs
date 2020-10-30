using DotNetAcademy.BikeShop.Host.Data.Extensions;
using DotNetAcademy.BikeShop.Host.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Host.Data
{
    public class BikeShopDbContext : DbContext
    {
        public BikeShopDbContext(DbContextOptions<BikeShopDbContext> options) : base(options)
        {
        }
        
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.AddFluentAPI();
        }
    }
}
