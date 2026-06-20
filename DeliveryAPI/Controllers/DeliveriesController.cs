using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Delivery.Data;
using DeliveryApp_Modelos;

namespace MiDeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly Delivery_Context _context;

        public DeliveriesController(Delivery_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryApp_Modelos.Delivery>>> GetDelivery()
        {
            return await _context.Deliveries
                .Include(d => d.Persona)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryApp_Modelos.Delivery>> GetDelivery(int id)
        {
            var delivery = await _context.Deliveries
                .Include(d => d.Persona)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (delivery == null)
                return NotFound();

            return delivery;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery(int id, DeliveryApp_Modelos.Delivery delivery)
        {
            if (id != delivery.Id)
                return BadRequest();

            _context.Entry(delivery).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<DeliveryApp_Modelos.Delivery>> PostDelivery(DeliveryApp_Modelos.Delivery delivery)
        {
            _context.Deliveries.Add(delivery);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDelivery),
                new { id = delivery.Id }, delivery);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery(int id)
        {
            var delivery = await _context.Deliveries.FindAsync(id);

            if (delivery == null)
                return NotFound();

            _context.Deliveries.Remove(delivery);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}