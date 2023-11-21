using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logFormaPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logFormaPago _instancia = new logFormaPago();
        //privado para evitar la instanciación directa
        public static logFormaPago Instancia
        {
            get
            {
                return logFormaPago._instancia;
            }
        }
        #endregion singleton
        public List<entFormaPago> ListarMetodoPago()
        {
            return datFormaPago.Instancia.ListarMetodoPago();
        }
        public void InsertarMetodoPago(entFormaPago mp)
        {
            datFormaPago.Instancia.InsertarMetodoPago(mp);
        }
    }
}
