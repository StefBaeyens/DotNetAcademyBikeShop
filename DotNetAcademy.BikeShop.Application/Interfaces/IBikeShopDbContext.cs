using System;
using System.Threading;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DotNetAcademy.BikeShop.Application.Interfaces
{
    public interface IBikeShopDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ShoppingBag> ShoppingBags { get; set; }
        DbSet<ShoppingItem> ShoppingItems { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        EntityEntry Update(object entity);
    }
}