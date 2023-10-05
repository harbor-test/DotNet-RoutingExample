using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return Json(new { ControllerName = "Weather", ActionName = "Index" });
        }
    }
}
