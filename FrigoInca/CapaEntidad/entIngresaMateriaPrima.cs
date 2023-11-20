using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entIngresaMateriaPrima
    {
        //IngresaMateriaPrima
        public int IdIngresaMateriaPrima { get; set; }
        public int IdOrdenCompra { get; set; }
        public string Proveedor { get; set; }
        public string MateriaPrima { get; set; }
        public string Peso { get; set; }
        public DateTime RegistroIngresoMP { get; set; }
    }
}
