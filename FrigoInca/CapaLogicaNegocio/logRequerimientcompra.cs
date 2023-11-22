using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaLogicaNegocio
{
    public class logRequerimientcompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logRequerimientcompra _instancia = new logRequerimientcompra();
        //privado para evitar la instanciación directa
        public static logRequerimientcompra Instancia
        {
            get
            {
                return logRequerimientcompra._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entRequerimientocompra> ListarRequerimientosCompra()
        {
            return datRequerimientocompra.Instancia.ListarRequerimientosCompra();
        }
        ///inserta
        public void InsertarRequerimientoCompra(entRequerimientocompra req)
        {
            datRequerimientocompra.Instancia.InsertarRequerimientoCompra(req);
        }
        public void EditarRequerimientoCompra(entRequerimientocompra MP)
        {
            datRequerimientocompra.Instancia.EditarRequerimientoCompra(MP);
        }
    }
}
