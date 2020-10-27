using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class ProductsController : Controller
    {
        private ICollection<ProductViewModel> _products = new List<ProductViewModel>
        {
            new ProductViewModel
            {
                Id = 1,
                Name = "Cannondale Moterra 1 Md 29 M",
                Price = 7999.00f
            },
            new ProductViewModel
            {
                Id = 2,
                Name = "Cannondale Slice Carbon 105",
                Price = 2174.00f
            },
            new ProductViewModel
            {
                Id = 3,
                Name = "Conway Ms 627",
                Price = 700.00f
            },
            new ProductViewModel
            {
                Id = 4,
                Name = "Pinarello Nytro Ultegra Disc H58",
                Price = 6999.00f
            }
        };

        public ProductsController()
        {
            
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            return View(_products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }
            return View(product);
        }
    }
}
