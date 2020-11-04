using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Application.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductViewModel>>
    {
        protected class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductViewModel>>
        {
            private readonly IBikeShopDbContext _bikeShopDbContext;
            private readonly IMapper _mapper;

            public GetProductsQueryHandler(IBikeShopDbContext bikeShopDbContext, IMapper mapper)
            {
                _bikeShopDbContext = bikeShopDbContext;
                _mapper = mapper;
            }

            public async Task<IEnumerable<ProductViewModel>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _bikeShopDbContext.Products.ToListAsync(cancellationToken);
                return _mapper.Map<IEnumerable<ProductViewModel>>(products);
            }
        }
    }
}
