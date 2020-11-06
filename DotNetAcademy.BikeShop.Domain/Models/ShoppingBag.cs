using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAcademy.BikeShop.Domain.Models
{
    public class ShoppingBag
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public ICollection<ShoppingItem> Items { get; set; }

        public ShoppingBag()
        {
            Items = new List<ShoppingItem>();
            Date = DateTime.Now;
        }
    }
}
