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
            private readonly IEnumerable<IDiscountRule> _discountRules;

            public GetShoppingBagByUserIdQueryHandler(IBikeShopDbContext context, IMapper mapper, IEnumerable<IDiscountRule> discountRules)
            {
                _context = context;
                _mapper = mapper;
                _discountRules = discountRules;
            }

            public async Task<ShoppingBagViewModel> Handle(GetShoppingBagByUserIdQuery request, CancellationToken cancellationToken)
            {
                var bag = await _context.ShoppingBags.Include(sb => sb.Items).ThenInclude(si => si.Product).SingleOrDefaultAsync(b => b.UserId == request.UserId, cancellationToken);
                if (bag == null) return null;

                var bagViewModel = _mapper.Map<ShoppingBagViewModel>(bag);

                var totalBeforeDiscounts = bag.Items.Select(item => item.Product.Price * item.Quantity).Sum();

                bagViewModel.Total = _discountRules.ApplyAll(bag, totalBeforeDiscounts);
                bagViewModel.TotalDiscount = totalBeforeDiscounts - bagViewModel.Total;

                return bagViewModel;
            }
        }
    }
}
