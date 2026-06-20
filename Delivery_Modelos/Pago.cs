using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Pago
    {
        public int Id { get; set; }

        public string MetodoPago { get; set; } = string.Empty;

        public double Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }
    }
}
