using DotNetAcademy.BikeShop.Host.Helpers;
using DotNetAcademy.BikeShop.Host.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAcademy.BikeShop.Host.Controllers
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
