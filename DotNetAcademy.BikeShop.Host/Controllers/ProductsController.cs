using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DotNetAcademy.BikeShop.Host.Data;
using DotNetAcademy.BikeShop.Host.Helpers;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class ProductsController : Controller
    {
        private const string BaseImagePath = "/images/bikes/";
        private BikeShopDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(BikeShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            var products = _mapper.Map<ICollection<ProductViewModel>>(_context.Products);
            foreach (var productViewModel in products)
            {
                productViewModel.PathToImage = BaseImagePath + BikeImageHelper.GetRandomImage();
            }
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null) return NotFound(id);

            var model = _mapper.Map<ProductViewModel>(product);

            model.PathToImage = BaseImagePath + BikeImageHelper.GetRandomImage();

            return View(model);
        }
    }
}
