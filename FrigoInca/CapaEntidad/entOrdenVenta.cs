using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenVenta
    {
        public int IdOrdendeventa { get; set; }
        public int Idloteproducto { get; set; }
        public int IdCliente { get; set; }
        public int IdDescuento { get; set; }
        public int IdFormapago { get; set; }
        public Boolean Estadoventa { get; set; }

        public DateTime Fechaventa { get; set; }
    }
}
