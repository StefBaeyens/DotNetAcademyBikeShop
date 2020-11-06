using System.Collections.Generic;
using System.Linq;
using DotNetAcademy.BikeShop.Domain.Models;

namespace DotNetAcademy.BikeShop.Application.Interfaces
{
    public interface IDiscountRule
    {
        decimal ApplyDiscount(ShoppingBag shoppingBag, decimal currentTotal);
    }

    public static class DiscountHelper
    {
        public static decimal ApplyAll(this IEnumerable<IDiscountRule> rules, ShoppingBag shoppingBag, decimal currentTotal)
        {
            return rules.Aggregate(currentTotal, (current, discountRule) => discountRule.ApplyDiscount(shoppingBag, current));
        }
    }
}
