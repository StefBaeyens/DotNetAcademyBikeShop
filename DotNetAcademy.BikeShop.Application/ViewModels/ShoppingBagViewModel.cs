using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetAcademy.BikeShop.Application.ViewModels
{
    public class ShoppingBagViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string UserId { get; set; }
        public ICollection<ShoppingItemViewModel> Items { get; set; }

        public decimal GetTotal => Items.Sum(i => i.TotalPrice);
    }
}
