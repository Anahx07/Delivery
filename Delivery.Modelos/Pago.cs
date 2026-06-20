using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Pago
    {
        public int IdPago { get; set; }
        public double Monto { get; set; }
        public string MetodoPago { get; set; }

        // relación con pedido
        public Pedido Pedido { get; set; } 
    }
}
