using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        //Proveedor
        public int Idproveedor { get; set; }
        public string Tipoproveedor { get; set; }
        public string Nombrecompletoproveedor { get; set; }
        public string Tipodocumentoproveedor { get; set; }
        public long Numerodocumentoproveedor { get; set; }
        public string Correoproveedor { get; set; }
        public int Telefonocontactoproveedor { get; set; }
        public Boolean Estadoproveedor { get; set; }
        public DateTime Fecharegistroproveedor { get; set; }
        public int IdUbigeo { get; set; }
    }
}
