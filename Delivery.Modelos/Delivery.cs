using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Delivery
    {
        public int IdDelivery { get; set; }
        public string Vehiculo { get; set; }
        public string EstadoEntrega { get; set; }

        // relación con Persona
        public Persona Persona { get; set; }

        // relación con pedidos
        public List<Pedido> Pedidos { get; set; }


        // relación con ubicación
        public Ubicacion? UbicacionActual { get; set; }
    }
}
