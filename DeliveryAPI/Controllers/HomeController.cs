using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
