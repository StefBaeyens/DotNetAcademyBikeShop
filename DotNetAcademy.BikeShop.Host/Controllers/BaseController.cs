using DotNetAcademy.BikeShop.Host.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetAcademy.BikeShop.Host.Controllers
{
    public class BaseController : Controller
    {
        private void Message(AlertMessageType type, string message, bool raw)
        {
            TempData["Message"] = JsonConvert.SerializeObject(new AlertMessage(type, message, raw));
        }

        public void MessageSuccess(string message, bool raw = false)
        {
            Message(AlertMessageType.Success, message, raw);
        }

        public void MessageWarning(string message, bool raw = false)
        {
            Message(AlertMessageType.Warning, message, raw);
        }
        public void MessageError(string message, bool raw = false)
        {
            Message(AlertMessageType.Error, message, raw);
        }
    }
}
