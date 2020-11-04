using System.ComponentModel.DataAnnotations;
using DotNetAcademy.BikeShop.Application.ViewModels;

namespace DotNetAcademy.BikeShop.Presentation.ViewModels
{
    public class AddToBasketViewModel
    {
        public ProductViewModel Product { get; set; }
        [Range(1, 999)]
        public int Quantity { get; set; }
    }
}
