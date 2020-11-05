using System;
using System.Collections.Generic;
using DotNetAcademy.BikeShop.Infrastructure.Models;

namespace DotNetAcademy.BikeShop.Presentation.Models
{
    public class ShoppingBag
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingItem> Items { get; set; }

        public ShoppingBag()
        {
            Items = new List<ShoppingItem>();
            Date = DateTime.Now;
        }

        // public void AddToBag(ShoppingItem item)
        // {
        //     var existingItem = Items.SingleOrDefault(shoppingItem => shoppingItem.Product == item.Product);
        //     if (existingItem != null)
        //     {
        //         existingItem.Quantity += item.Quantity;
        //     }
        //     else
        //     {
        //         item.Bag = this;
        //         Items.Add(item);
        //     }
        // }
    }
}
