using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logDescuento
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDescuento _instancia = new logDescuento();
        //privado para evitar la instanciación directa
        public static logDescuento Instancia
        {
            get
            {
                return logDescuento._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entDescuento> ListarDescuento()
        {
            return datDescuento.Instancia.ListarDescuento();
        }
        ///inserta
        public void InsertarDescuento(entDescuento descuento)
        {
            datDescuento.Instancia.InsertarDescuento(descuento);
        }
    }
}
