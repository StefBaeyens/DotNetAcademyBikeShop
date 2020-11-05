using System;
using System.Collections.Generic;
using DotNetAcademy.BikeShop.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace DotNetAcademy.BikeShop.Infrastructure.Models
{
    public class Customer : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

        public ShoppingBag Bags { get; set; }

        public Customer()
        {
            Bags = new ShoppingBag
            {
                Date = DateTime.Now,
                UserId = Id
            };
        }
    }
}
