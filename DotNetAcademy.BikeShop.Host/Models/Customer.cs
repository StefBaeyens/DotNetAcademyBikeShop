using System.Collections.Generic;

namespace DotNetAcademy.BikeShop.Host.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public ICollection<ShoppingBag> Bags { get; set; }
    }
}
