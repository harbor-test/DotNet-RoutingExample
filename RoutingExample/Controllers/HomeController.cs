using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace RoutingExample.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return Json(new { ControllerName = "Home", ActionName = "Index", RouteParameter = new List<int>() });
        }

    }
}
