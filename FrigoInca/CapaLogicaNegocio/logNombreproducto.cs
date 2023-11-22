using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logNombreproducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logNombreproducto _instancia = new logNombreproducto();
        //privado para evitar la instanciación directa
        public static logNombreproducto Instancia
        {
            get
            {
                return logNombreproducto._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entNombreproducto> ListarNombreproducto()
        {
            return datNombreproducto.Instancia.ListarNombreproducto();
        }
        public void InsertarNombreproducto(entNombreproducto ubigeo)
        {
            datNombreproducto.Instancia.InsertarNombreproducto(ubigeo);
        }
    }
}
