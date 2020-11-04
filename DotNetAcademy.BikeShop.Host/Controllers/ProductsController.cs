using System.Linq;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Application.Commands;
using DotNetAcademy.BikeShop.Application.Queries;
using DotNetAcademy.BikeShop.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace DotNetAcademy.BikeShop.Presentation.Controllers
{
    // [Authorize]
    public class ProductsController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: ProductsController
        public async Task<IActionResult> Index(int? page)
        {
            var response = await _mediator.Send(new GetProductsQuery());

            const int pageSize = 9;
            var pageNumber = page ?? 1;

            //I know this enumerates the results the items before paging but for this project + amount of data I think it's fine
            var model = response.ToPagedList(pageNumber, pageSize);

            if (page > model.PageCount) return NotFound();

            return View(model);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _mediator.Send(new GetProductQuery { Id = id });

            if (product == null) return NotFound(id);

            return View(product);
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
            var addedProduct = await _mediator.Send(new AddProductCommand { Model = product });
            MessageSuccess("The product was successfully created.");
            return RedirectToAction("Details", addedProduct.Id);
        }

        /*// GET: Products/Edit/5
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
        }*/
    }
}
