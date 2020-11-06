using System.Threading;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using MediatR;

namespace DotNetAcademy.BikeShop.Application.Commands
{
    public class UpdateProductCommand : IRequest
    {
        public ProductViewModel Product { get; set; }

        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
        {
            private readonly IBikeShopDbContext _context;

            public UpdateProductCommandHandler(IBikeShopDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
            {
                var product = await _context.Products.FindAsync(request.Product.Id);

                product.Name = request.Product.Name;
                product.Price = request.Product.Price;

                _context.Update(product);
                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
