using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logOrdencompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdencompra _instancia = new logOrdencompra();
        //privado para evitar la instanciación directa
        public static logOrdencompra Instancia
        {
            get
            {
                return logOrdencompra._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entOrdencompra> ListarOrdencompra()
        {
            return datOrdencompra.Instancia.ListarOrdencompra();
        }
        ///inserta
        public void InsertarOrdencompra(entOrdencompra animal)
        {
            datOrdencompra.Instancia.InsertarOrdencompra(animal);
        }
    }
}
