using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Application.Queries
{
    public class GetShoppingBagByUserIdQuery : IRequest<ShoppingBagViewModel>
    {
        public string UserId { get; set; }

        public class GetShoppingBagByUserIdQueryHandler : IRequestHandler<GetShoppingBagByUserIdQuery, ShoppingBagViewModel>
        {
            private readonly IBikeShopDbContext _context;
            private readonly IMapper _mapper;

            public GetShoppingBagByUserIdQueryHandler(IBikeShopDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ShoppingBagViewModel> Handle(GetShoppingBagByUserIdQuery request, CancellationToken cancellationToken)
            { 
                var bag = await _context.ShoppingBags.Include(sb => sb.Items).ThenInclude(si => si.Product).SingleOrDefaultAsync(b => b.UserId == request.UserId, cancellationToken);
                return bag == null ? null : _mapper.Map<ShoppingBagViewModel>(bag);
            }
        }
    }
}
