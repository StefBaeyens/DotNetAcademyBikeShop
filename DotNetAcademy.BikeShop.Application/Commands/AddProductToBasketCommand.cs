using System;
using System.Collections.Generic;
using System.Text;
using DotNetAcademy.BikeShop.Application.ViewModels;
using MediatR;

namespace DotNetAcademy.BikeShop.Application.Commands
{
    public class AddProductToBasketCommand : IRequest
    {
        public ProductViewModel Product { get; set; }
    }
}
