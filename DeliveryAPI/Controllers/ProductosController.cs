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
    public class ProductosController : ControllerBase
    {
        private readonly Delivery_Context _context;

        public ProductosController(Delivery_Context context)
=======
using Microsoft.AspNetCore.Mvc;
using Delivery.Data;

namespace DeliveryAPI.Controllers
{
    public class ProductosController : Controller
    {
        private readonly DeliveryAppContext _context;

        public ProductosController(DeliveryAppContext context)
>>>>>>> 88f631366bcfb865b98421b11c8c40297b9aedb1
        {
            _context = context;
        }

<<<<<<< HEAD
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProducto()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Productos.Add(producto);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducto),
                new { id = producto.Id }, producto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);

            await _context.SaveChangesAsync();

            return NoContent();
=======
        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
>>>>>>> 88f631366bcfb865b98421b11c8c40297b9aedb1
        }
    }
}