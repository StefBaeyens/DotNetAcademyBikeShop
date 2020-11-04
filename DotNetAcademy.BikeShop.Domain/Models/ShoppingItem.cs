﻿namespace DotNetAcademy.BikeShop.Domain.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public int BagId { get; set; }
        public ShoppingBag Bag { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
