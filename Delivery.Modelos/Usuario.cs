using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string Direccion { get; set; }

        // relación con Persona
        public Persona Persona { get; set; }

        // relación con pedidos
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
