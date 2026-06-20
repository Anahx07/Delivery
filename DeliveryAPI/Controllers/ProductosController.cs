using Microsoft.AspNetCore.Mvc;
using Delivery.Data;

namespace DeliveryAPI.Controllers
{
    public class ProductosController : Controller
    {
        private readonly DeliveryAppContext _context;

        public ProductosController(DeliveryAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
        }
    }
}
