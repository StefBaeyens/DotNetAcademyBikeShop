using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Host.Data;
using DotNetAcademy.BikeShop.Host.Models;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    [Authorize]
    public class ShoppingBagController : BaseController
    {
        private readonly BikeShopDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<Customer> _userManager;

        public ShoppingBagController(BikeShopDbContext context, IMapper mapper, UserManager<Customer> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //TODO: Move to handler
            var bags = _context.ShoppingBags.Where(b => b.CustomerId == customerId).Include(c => c.Items).ThenInclude(item => item.Product).ToList();
            var bag = bags.FirstOrDefault() ?? (await _context.ShoppingBags.AddAsync(new ShoppingBag
            {
                CustomerId = customerId,
                Date = DateTime.Now
            })).Entity;
            //====================
            return View(_mapper.Map<ShoppingBagViewModel>(bag));
        }
    }
}
