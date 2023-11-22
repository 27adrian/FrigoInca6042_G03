using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logCorte
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCorte _instancia = new logCorte();
        //privado para evitar la instanciación directa
        public static logCorte Instancia
        {
            get
            {
                return logCorte._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entCorte> ListarCorte()
        {
            return datCorte.Instancia.ListarCorte();
        }
        public void InsertarCorte(entCorte corte)
        {
            datCorte.Instancia.InsertarCorte(corte);
        }
    }
}
