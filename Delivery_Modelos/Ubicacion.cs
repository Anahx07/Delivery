using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Ubicacion
    {
        public int Id { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Referencia { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }

        public ICollection<Delivery>? Deliveries { get; set; }
    }
}
