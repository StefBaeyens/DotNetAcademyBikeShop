using DotNetAcademy.BikeShop.Infrastructure.Helpers;
using DotNetAcademy.BikeShop.Presentation.Helpers;
using DotNetAcademy.BikeShop.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAcademy.BikeShop.Presentation.Controllers
{
    public class HomeController : BaseController
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
