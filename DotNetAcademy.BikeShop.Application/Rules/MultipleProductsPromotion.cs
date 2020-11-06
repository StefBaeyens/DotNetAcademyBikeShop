using System;
using System.Collections.Generic;
using System.Text;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Domain.Models;

namespace DotNetAcademy.BikeShop.Application.Rules
{
    public class MultipleProductsPromotion : IDiscountRule
    {
        public decimal ApplyDiscount(ShoppingBag shoppingBag, decimal currentTotal)
        {
            if (shoppingBag.Items == null) return currentTotal;

            if (shoppingBag.Items.Count >= 6)
            {
                return currentTotal * 0.9m;
            }

            if (shoppingBag.Items.Count >= 3)
            {
                return currentTotal * 0.95m;
            }

            return currentTotal;
        }
    }
}
