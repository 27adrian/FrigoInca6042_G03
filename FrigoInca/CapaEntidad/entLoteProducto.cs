using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entLoteProducto
    {
        public int IdLoteproducto { get; set; }

        public int IdIngresomateriaprima { get; set; }

        public int IdCorte { get; set; }

        public int IdNombreproducto { get; set; }

        public decimal Peso { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fechalote { get; set; }
    }
}
