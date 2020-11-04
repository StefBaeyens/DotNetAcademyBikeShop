using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using FluentValidation;
using MediatR;

namespace DotNetAcademy.BikeShop.Application.Queries
{
    
    public class GetProductQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }

        public class GetProductQueryValidator : AbstractValidator<GetProductQuery>
        {
            public GetProductQueryValidator()
            {
                RuleFor(m => m.Id).Must(BeValidId).WithMessage("This is not a valid Id. Lol.");
            }

            private static bool BeValidId(int id)
            {
                return id >= 0;
            }
        }

        protected class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductViewModel>
        {
            private readonly IBikeShopDbContext _context;
            private readonly IMapper _mapper;

            public GetProductQueryHandler(IBikeShopDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ProductViewModel> Handle(GetProductQuery request, CancellationToken cancellationToken)
            {
                var product = await _context.Products.FindAsync(request.Id);
                return _mapper.Map<ProductViewModel>(product);
            }
        }
    }
}
