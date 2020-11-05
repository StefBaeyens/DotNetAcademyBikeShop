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
    public class AddProductToBasketCommand : IRequest
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public class AddProductToBasketCommandHandler : IRequestHandler<AddProductToBasketCommand>
        {
            private readonly IBikeShopDbContext _context;

            public AddProductToBasketCommandHandler(IBikeShopDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(AddProductToBasketCommand request, CancellationToken cancellationToken)
            {
                var bag = await _context
                    .ShoppingBags
                    .Include(b => b.Items)
                    .ThenInclude(i => i.Product)
                    .SingleOrDefaultAsync(b => b.Id == request.BasketId, cancellationToken);

                var item = bag.Items.SingleOrDefault(i => i.ProductId == request.ProductId);

                if (item == default)
                {
                    var product = await _context.Products.FindAsync(request.ProductId, cancellationToken);
                    item = new ShoppingItem
                    {
                        Product = product,
                        Quantity = request.Quantity,
                        Bag = bag
                    };
                    bag.Items.Add(item);
                }
                else
                {
                    item.Quantity += request.Quantity;
                }

                await _context.SaveChangesAsync(cancellationToken);

                return new Unit();
            }
        }
    }
}
