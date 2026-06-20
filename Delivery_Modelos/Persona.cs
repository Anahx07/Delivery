using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp_Modelos
{
    public class Persona
    {
        public int Id { get; set; }              // clave primaria
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // relaciones
        public Usuario? Usuario { get; set; }
        public Admin? Admin { get; set; }
        public Delivery? Delivery { get; set; }
    }
}
