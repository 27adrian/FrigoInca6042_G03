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
        public int IdIngresomateriaprima { get; set; }
        public int IdOrdencompra { get; set; }
        public decimal Peso { get; set; }
        public string Calidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
