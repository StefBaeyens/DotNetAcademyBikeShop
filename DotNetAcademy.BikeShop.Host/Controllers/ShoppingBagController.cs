using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Host.Data;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class ShoppingBagController : BaseController
    {
        private readonly BikeShopDbContext _context;
        private readonly IMapper _mapper;

        public ShoppingBagController(BikeShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var bag = _context.ShoppingBags.Include(b => b.Items).ThenInclude(i => i.Product).SingleOrDefault();
            return View(_mapper.Map<ShoppingBagViewModel>(bag));
        }
    }
}
