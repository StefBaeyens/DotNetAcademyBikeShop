using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DotNetAcademy.BikeShop.Application.Queries;
using DotNetAcademy.BikeShop.Presentation.Models;
using DotNetAcademy.BikeShop.Presentation.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetAcademy.BikeShop.Presentation.Controllers
{
    [Authorize]
    public class ShoppingBagController : BaseController
    {
        private readonly IMediator _mediator;

        public ShoppingBagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new GetShoppingBagByUserIdQuery
            {
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            });
            return View(result);
        }
    }
}
