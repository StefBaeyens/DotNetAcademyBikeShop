using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Interfaces;
using DotNetAcademy.BikeShop.Application.ViewModels;
using DotNetAcademy.BikeShop.Domain.Models;
using FluentValidation;
using MediatR;

namespace DotNetAcademy.BikeShop.Application.Commands
{
    public class AddProductCommand : IRequest<ProductViewModel>
    {
        public ProductViewModel Model { get; set; }

        public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
        {
            public AddProductCommandValidator()
            {
                RuleFor(m => m.Model.Name).Must(BeValidName).WithMessage("The name is required.");
                RuleFor(m => m.Model.Price).Must(BeValidPrice).WithMessage("The price must be a positive number above 0.");
            }

            private static bool BeValidName(string name)
            {
                return !string.IsNullOrWhiteSpace(name);
            }

            private static bool BeValidPrice(decimal price)
            {
                return price > 0;
            }
        }

        protected class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductViewModel>
        {
            private readonly IMapper _mapper;
            private readonly IBikeShopDbContext _context;

            public AddProductCommandHandler(IMapper mapper, IBikeShopDbContext context)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<ProductViewModel> Handle(AddProductCommand request, CancellationToken cancellationToken)
            {
                var productToAdd = _mapper.Map<Product>(request.Model);

                var result = (await _context.Products.AddAsync(productToAdd, cancellationToken)).Entity;
                await _context.SaveChangesAsync(cancellationToken);

                return _mapper.Map<ProductViewModel>(result);
            }
        }
    }
}
