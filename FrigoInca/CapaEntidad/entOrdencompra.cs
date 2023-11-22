using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdencompra
    {
        public int IdOrdencompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdFormapago { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fechacompra { get; set; }
    }
}
