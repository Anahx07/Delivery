using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Admin
    {
        public int Id { get; set; }

        public string Cargo { get; set; } = string.Empty;

        public int PersonaId { get; set; }

        public Persona? Persona { get; set; }
    }
}
