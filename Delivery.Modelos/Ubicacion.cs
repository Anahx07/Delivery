using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Modelos
{
    internal class Ubicacion
    {
        public int IdUbicacion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public DateTime Hora { get; set; }

        // relación con Delivery
        public Delivery Delivery { get; set; }
    }
}
