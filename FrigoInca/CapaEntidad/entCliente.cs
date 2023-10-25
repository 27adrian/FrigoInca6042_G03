using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int Idcliente { get; set; }
        public string Tipocliente { get; set; }
        public string Nombrecompleto { get; set; }
        public string Tipodocumento { get; set; }
        public long Numerodocumento { get; set; }
        public string Correo { get; set; }
        public int Telefonocontacto { get; set; }
        public Boolean Estadocliente { get; set; }
        public DateTime Fecharegistrocliente { get; set; }
    }
}
