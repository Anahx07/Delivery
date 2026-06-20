using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Delivery
    {
        public int Id { get; set; }

        public string Vehiculo { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;

        public int PersonaId { get; set; }

        public Persona? Persona { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }

        public int? UbicacionActualId { get; set; }

        public Ubicacion? UbicacionActual { get; set; }
    }
}
