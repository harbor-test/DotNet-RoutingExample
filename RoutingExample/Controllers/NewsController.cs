using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RoutingExample.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult List()
        {
            return Json(new { ControllerName = "News", ActionName = "List", RouteParameter = new List<int>() });
        }

        public IActionResult Details(int id = 0)
        {
            return Json(new { ControllerName = "News", ActionName = "Details", RouteParameter = new List<int>() { id} });
        }
    }
}
