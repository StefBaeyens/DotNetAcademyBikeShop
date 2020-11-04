using DotNetAcademy.BikeShop.Application.ViewModels;

namespace DotNetAcademy.BikeShop.Presentation.ViewModels
{
    public class ShoppingItemViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int BagId { get; set; }
        public ShoppingBagViewModel Bag { get; set; }
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }

        public decimal TotalPrice => Quantity * Product.Price;
    }
}
