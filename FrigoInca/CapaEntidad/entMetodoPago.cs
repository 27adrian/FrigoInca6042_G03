using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMetodoPago
    {
        public int IdMetodoPago { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public Boolean EstadoMetodoPago { get; set; }

    }
}
