using Microsoft.AspNetCore.Mvc;
using Delivery.Data;
using Microsoft.EntityFrameworkCore;

namespace DeliveryAPI.Controllers
{
    public class PedidosController : Controller
    {
        private readonly DeliveryAppContext _context;

        public PedidosController(DeliveryAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Incluimos la información del usuario y el repartidor para una mejor vista
            var pedidos = _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.Delivery)
                .ToList();
            return View(pedidos);
        }
    }
}
