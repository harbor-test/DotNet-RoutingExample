using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RoutingExample.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return Json(new { ControllerName = "Weather", ActionName = "Index", RouteParameter = new List<string>() { RouteData.Values["cityID"]?.ToString() } });
        }
    }
}
