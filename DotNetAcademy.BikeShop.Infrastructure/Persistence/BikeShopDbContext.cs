using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Domain.Models;
using DotNetAcademy.BikeShop.Infrastructure.Models;
using DotNetAcademy.BikeShop.Infrastructure.Persistence.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Infrastructure.Persistence
{
    public class BikeShopDbContext : IdentityDbContext<Customer>, IBikeShopDbContext
    {
        public BikeShopDbContext(DbContextOptions<BikeShopDbContext> options) : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.AddFluentAPI();
        }
    }
}
