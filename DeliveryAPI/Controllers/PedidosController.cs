<<<<<<< HEAD
﻿using System;
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
    public class PedidosController : ControllerBase
    {
        private readonly Delivery_Context _context;

        public PedidosController(Delivery_Context context)
=======
using Microsoft.AspNetCore.Mvc;
using Delivery.Data;
using Microsoft.EntityFrameworkCore;

namespace DeliveryAPI.Controllers
{
    public class PedidosController : Controller
    {
        private readonly DeliveryAppContext _context;

        public PedidosController(DeliveryAppContext context)
>>>>>>> 88f631366bcfb865b98421b11c8c40297b9aedb1
        {
            _context = context;
        }

<<<<<<< HEAD
        // GET: api/Pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            return await _context.Pedidos

    .Include(p => p.Usuario)
        .ThenInclude(u => u.Persona)

    .Include(p => p.Pago)

    .Include(p => p.Ubicacion)

    .Include(p => p.Delivery)
        .ThenInclude(d => d.Persona)

    .Include(p => p.DetallesPedido)
        .ThenInclude(d => d.Producto)

    .ToListAsync();
        }

        // GET: api/Pedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _context.Pedidos

    .Include(p => p.Usuario)
        .ThenInclude(u => u.Persona)

    .Include(p => p.Pago)

    .Include(p => p.Ubicacion)

    .Include(p => p.Delivery)
        .ThenInclude(d => d.Persona)

    .Include(p => p.DetallesPedido)
        .ThenInclude(d => d.Producto)

    .FirstOrDefaultAsync(p => p.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return pedido;
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }

                throw;
            }

            return NoContent();
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetPedido),
                new { id = pedido.Id },
                pedido
            );
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                return NotFound();
            }

            _context.Pedidos.Remove(pedido);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
=======
        public IActionResult Index()
        {
            // Incluimos la información del usuario y el repartidor para una mejor vista
            var pedidos = _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.Delivery)
                .ToList();
            return View(pedidos);
>>>>>>> 88f631366bcfb865b98421b11c8c40297b9aedb1
        }
    }
}