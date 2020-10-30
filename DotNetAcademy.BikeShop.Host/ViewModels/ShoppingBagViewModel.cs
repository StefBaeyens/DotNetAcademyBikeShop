using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Host.Models;

namespace DotNetAcademy.BikeShop.Host.ViewModels
{
    public class ShoppingBagViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingItemViewModel> Items { get; set; }

        public decimal GetTotal => Items.Sum(i => i.TotalPrice);
    }
}
