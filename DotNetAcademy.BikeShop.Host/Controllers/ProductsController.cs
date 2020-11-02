using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Host.Data;
using DotNetAcademy.BikeShop.Host.Models;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PagedList;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    [Authorize]
    public class ProductsController : BaseController
    {
        private readonly BikeShopDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(BikeShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: ProductsController
        public IActionResult Index(int? page)
        {
            if (page < 1) return NotFound();

            var products = _mapper.Map<ICollection<ProductViewModel>>(_context.Products.OrderBy(product => product.Price));

            const int pageSize = 9;
            var pageNumber = page ?? 1;

            var model = products.ToPagedList(pageNumber, pageSize);

            if (page > model.PageCount) return NotFound();

            return View(model);
        }

        // GET: Products/Details/5
        public IActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null) return NotFound(id);

            return View(_mapper.Map<ProductViewModel>(product));
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,PathToImage")] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                //TODO: Move to handler
                var savedProduct = (await _context.Products.AddAsync(_mapper.Map<Product>(product))).Entity;
                await _context.SaveChangesAsync();
                MessageSuccess("The product was successfully created.");
                return RedirectToAction("Details", savedProduct.Id);
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,PathToImage")] ProductViewModel product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //TODO: Move to handler
                _context.Update(product);
                await _context.SaveChangesAsync();
                MessageSuccess("The product was successfully updated.");
                return RedirectToAction(nameof(Details));
            }

            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //TODO: Move to handler
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            MessageSuccess("The product was successfully deleted.");
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> AddToBasket(AddToBasketViewModel model)
        {
            //TODO: Move to seperate handler
            var customer = _context.Customers.Include(c => c.Bags).ThenInclude(b => b.Items).SingleOrDefault();

            if (customer == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var bag = customer.Bags.FirstOrDefault();

            if (bag == null)
            {
                bag = (await _context.ShoppingBags.AddAsync(new ShoppingBag
                {
                    Customer = customer,
                    Date = DateTime.Now
                })).Entity;
            }

            var product = await _context.Products.FindAsync(model.Product.Id);

            bag.AddToBag(new ShoppingItem { Product = product, Quantity = model.Quantity });
            //=====================

            await _context.SaveChangesAsync();

            MessageSuccess("This item was successfully added to your basket");

            return RedirectToAction("Index");
        }
    }
}
