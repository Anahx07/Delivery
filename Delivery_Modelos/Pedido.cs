using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime FechaPedido { get; set; }

        public string Estado { get; set; } = string.Empty;

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public int PagoId { get; set; }
        public Pago? Pago { get; set; }

        public int UbicacionId { get; set; }
        public Ubicacion? Ubicacion { get; set; }

        public int DeliveryId { get; set; }
        public Delivery? Delivery { get; set; }

        public ICollection<DetallePedido>? DetallesPedido { get; set; }
    }
}
