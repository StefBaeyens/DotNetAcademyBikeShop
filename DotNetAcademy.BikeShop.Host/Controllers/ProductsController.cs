using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Host.Data;
using DotNetAcademy.BikeShop.Host.Models;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class ProductsController : BaseController
    {
        private BikeShopDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(BikeShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: ProductsController
        public ActionResult Index(int? page)
        {
            if (page < 1) return NotFound();

            var products = _mapper.Map<ICollection<ProductViewModel>>(_context.Products.OrderBy(product => product.Price));

            const int pageSize = 9;
            var pageNumber = page ?? 1;

            var model = products.ToPagedList(pageNumber, pageSize);

            if (page > model.PageCount) return NotFound();

            return View(model);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null) return NotFound(id);

            return View(_mapper.Map<ProductViewModel>(product));
        }

        public async Task<ActionResult> AddToBasket(AddToBasketViewModel model)
        {
            //TODO: Move to seperate handler
            var customer = _context.Customers.Include(c => c.Bags).ThenInclude(b => b.Items).SingleOrDefault();

            if (customer == null)
            {
                customer = new Customer
                {
                    FirstName = "Stef",
                    Name = "Baeyens",
                    Bags = new List<ShoppingBag>
                    {
                        new ShoppingBag()
                    }
                };
                customer = (await _context.Customers.AddAsync(customer)).Entity;
            }

            var bag = customer.Bags.First();
            var product = await _context.Products.FindAsync(model.Product.Id);

            bag.AddToBag(new ShoppingItem{Product = product, Quantity = model.Quantity});
            //=====================

            await _context.SaveChangesAsync();

            MessageSuccess("This item was successfully added to your basket");

            return RedirectToAction("Index");
        }
    }
}
