using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Correo { get; set; }

        public string Password { get; set; }

        // FK Persona
        public int PersonaId { get; set; }

        public Persona? Persona { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }
    }
}
