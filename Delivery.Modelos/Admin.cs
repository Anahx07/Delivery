using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Admin
    {
        public int IdAdmin { get; set; }
        public string Rol { get; set; } = "Administrador";

        // relación con Persona
        public Persona Persona { get; set; }

        // relación con productos
        public List<Producto> Productos { get; set; } 
    }
}
