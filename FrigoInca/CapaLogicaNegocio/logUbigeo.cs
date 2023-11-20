using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logUbigeo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUbigeo _instancia = new logUbigeo();
        //privado para evitar la instanciación directa
        public static logUbigeo Instancia
        {
            get
            {
                return logUbigeo._instancia;
            }
        }
        #endregion singleton
        public List<entUbigeo> ListarUbigeo()
        {
            return datUbigeo.Instancia.ListarUbigeo();
        }
        ///inserta
        public void InsertarUbigeo(entUbigeo ubigeo)
        {
            datUbigeo.Instancia.InsertarUbigeo(ubigeo);
        }
        //edita
        public void EditarUbigeo(entUbigeo ubigeo)
        {
            datUbigeo.Instancia.EditarUbigeo(ubigeo);
        }
        public void InhabilitarUbigeo(entUbigeo ubigeo)
        {
            datUbigeo.Instancia.InhabilitarUbigeo(ubigeo);
        }
    }
}
