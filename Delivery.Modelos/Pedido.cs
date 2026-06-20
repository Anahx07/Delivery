using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        // relaciones
        public Usuario Usuario { get; set; }
        public Delivery Delivery { get; set; }
        public List<Producto> ListaProductos { get; set; }

        // relación con pago
        public Pago? Pago { get; set; }
    }
}
