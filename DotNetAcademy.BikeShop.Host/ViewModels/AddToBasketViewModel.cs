using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAcademy.BikeShop.Host.ViewModels
{
    public class AddToBasketViewModel
    {
        public ProductViewModel Product { get; set; }
        [Range(1, 999)]
        public int Quantity { get; set; }
    }
}
