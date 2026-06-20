using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Persona
    {
        public int Id { get; set; }              // clave primaria
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // relaciones
        public Usuario? Usuario { get; set; }
        public Admin? Admin { get; set; }
        public Delivery? Delivery { get; set; }
    }
}
