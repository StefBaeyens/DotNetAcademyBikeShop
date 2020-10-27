using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAcademy.BikeShop.Host.Helpers;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel
            {
                PathToBikeImage = "/images/bikes/" + BikeImageHelper.GetRandomImage()
            });
        }
    }
}
