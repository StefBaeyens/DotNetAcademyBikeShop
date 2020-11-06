using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using DotNetAcademy.BikeShop.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Application.Commands
{
    public class AddToBasketCommand : IRequest
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public class AddProductToBasketCommandHandler : IRequestHandler<AddToBasketCommand>
        {
            private readonly IBikeShopDbContext _context;
            private readonly IMediator _mediator;

            public AddProductToBasketCommandHandler(IBikeShopDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(AddToBasketCommand request, CancellationToken cancellationToken)
            {
                var bag = await GetShoppingBagByUserId(request.UserId) ?? await CreateNewShoppingBag();

                var product = await _context.Products.FindAsync(new object[] { request.ProductId }, cancellationToken);

                AddToBag(bag, new ShoppingItem(bag, product, request.Quantity));

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;

                async Task<ShoppingBag> GetShoppingBagByUserId(string userId)
                {
                    return await _context
                        .ShoppingBags
                        .Include(b => b.Items)
                        .ThenInclude(i => i.Product)
                        .FirstOrDefaultAsync(b => b.UserId == userId, cancellationToken);
                }

                async Task<ShoppingBag> CreateNewShoppingBag()
                {
                    return (await _context.ShoppingBags.AddAsync(new ShoppingBag
                    {
                        UserId = request.UserId,
                        Date = DateTime.Now
                    }, cancellationToken)).Entity;
                }

                static void AddToBag(ShoppingBag bag, ShoppingItem item)
                {
                    var existingItem = bag.Items.SingleOrDefault(shoppingItem => shoppingItem.Product == item.Product);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += item.Quantity;
                    }
                    else
                    {
                        item.Bag = bag;
                        bag.Items.Add(item);
                    }
                }
            }
        }
    }
}
