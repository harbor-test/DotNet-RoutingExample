using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Get(int id)
        {
            return View();
        }

        public IActionResult CustomerOrder(int id)
        {
            return View();
        }
    }
}
