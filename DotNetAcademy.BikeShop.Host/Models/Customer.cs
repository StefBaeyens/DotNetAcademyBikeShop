using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DotNetAcademy.BikeShop.Host.Models
{
    public class Customer : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

        public ICollection<ShoppingBag> Bags { get; set; }

        public Customer()
        {
            Bags = new List<ShoppingBag>();
        }
    }
}
