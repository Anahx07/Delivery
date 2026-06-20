using Delivery_Modelos;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Data
{
    public class DeliveryAppContext : DbContext
    {
        public DeliveryAppContext(DbContextOptions<DeliveryAppContext> options)
            : base(options)
        {
        }

        // Tablas principales
        public DbSet<Persona> Personas { get; set; } = default!;
        public DbSet<Usuario> Usuarios { get; set; } = default!;
        public DbSet<Admin> Administradores { get; set; } = default!;
        public DbSet<Delivery_Modelos.Delivery> Deliveries { get; set; } = default!;

        // Tablas del negocio
        public DbSet<Producto> Productos { get; set; } = default!;
        public DbSet<Pedido> Pedidos { get; set; } = default!;
        public DbSet<Pago> Pagos { get; set; } = default!;
        public DbSet<Ubicacion> Ubicaciones { get; set; } = default!;
    }
}

