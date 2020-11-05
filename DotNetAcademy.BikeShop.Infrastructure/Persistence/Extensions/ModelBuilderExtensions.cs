using System;
using System.Collections.Generic;
using System.IO;
using DotNetAcademy.BikeShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Customer = DotNetAcademy.BikeShop.Infrastructure.Models.Customer;

namespace DotNetAcademy.BikeShop.Infrastructure.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            SeedProducts(modelBuilder);
        }

        public static void AddFluentAPI(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(customer => customer.Name).IsRequired();
            modelBuilder.Entity<Customer>().Property(customer => customer.FirstName).IsRequired();

            modelBuilder.Entity<ShoppingBag>().Property(bag => bag.Date).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<ShoppingBag>().Property(bag => bag.UserId).IsRequired();

            modelBuilder.Entity<ShoppingItem>().Property(item => item.Quantity).IsRequired();

            modelBuilder.Entity<Product>().Property(product => product.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(product => product.Price).IsRequired().HasColumnType("decimal(8,2)");
        }

        private static void SeedProducts(ModelBuilder modelBuilder)
        {
            var productList = new List<Product>();

            for (var i = 0; i < 50; i++)
            {
                productList.Add(GenerateRandomProduct(i + 1));
            }

            modelBuilder.Entity<Product>().HasData(productList);

            static Product GenerateRandomProduct(int id)
            {
                return new Product
                {
                    Id = id,
                    Name = GetRandomString(),
                    Price = (decimal) Math.Round(new Random().NextDouble() * 500, 2)
                };

                //TODO: Remove! Solely use this for testing purposes
                static string GetRandomString()
                {
                    return Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
                }
            }
        }
    }
}
