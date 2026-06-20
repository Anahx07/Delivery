using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeliveryApp_Modelos;

namespace Delivery.Data
{
    public class Delivery_Context : DbContext
    {
        public Delivery_Context(DbContextOptions<Delivery_Context> options)
            : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; } 

        public DbSet<Usuario> Usuarios { get; set; } = default!;

        public DbSet<Admin> Admins { get; set; }

        public DbSet<DeliveryApp_Modelos.Delivery> Deliveries { get; set; } 

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Pago> Pagos { get; set; }

        public DbSet<Ubicacion> Ubicaciones { get; set; }

        public DbSet<DetallePedido> DetallesPedido { get; set; }

    }
}

