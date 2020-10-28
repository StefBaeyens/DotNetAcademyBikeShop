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
            return View(_mapper.Map<ICollection<ProductViewModel>>(_context.Products));
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null) return NotFound(id);

            return View(_mapper.Map<ProductViewModel>(product));
        }
    }
}
