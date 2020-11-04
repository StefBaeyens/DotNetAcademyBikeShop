using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetAcademy.BikeShop.Presentation.ViewModels
{
    public class ShoppingBagViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ShoppingItemViewModel> Items { get; set; }

        public decimal GetTotal => Items.Sum(i => i.TotalPrice);
    }
}
