using Microsoft.AspNetCore.Mvc;
using Delivery.Data;

namespace DeliveryAPI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly DeliveryAppContext _context;

        public ClientesController(DeliveryAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Retorna la vista con la lista de personas (clientes)
            var clientes = _context.Personas.ToList();
            return View(clientes);
        }
    }
}
