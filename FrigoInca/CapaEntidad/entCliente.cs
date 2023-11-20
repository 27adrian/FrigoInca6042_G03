using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        //Cliente
        public int Idcliente { get; set; }
        public string Tipocliente { get; set; }
        public string Nombrecompletocliente { get; set; }
        public string Tipodocumentocliente { get; set; }
        public long Numerodocumentocliente { get; set; }
        public string Correocliente { get; set; }
        public int Telefonocontactocliente { get; set; }
        public Boolean Estadocliente { get; set; }
        public DateTime Fecharegistrocliente { get; set; }
        public int IdUbigeo { get; set; }

    }
}
