using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<entProveedor> Listarproveedor()
        {
            return datProveedor.Instancia.Listarproveedor();
        }
        ///inserta
        public bool Insertarproveedor(entProveedor Prov)
        {
            return datProveedor.Instancia.Insertarproveedor(Prov);
        }
        //edita
        public void Editarproveedor(entProveedor Prov)
        {
            datProveedor.Instancia.Editarproveedor(Prov);
        }
        public void Deshabilitarproveedor(entProveedor Prov)
        {
            datProveedor.Instancia.Deshabilitarproveedor(Prov);
        }

        public List<entProveedor> BuscarProveedor(entProveedor Prov)
        {
            return datProveedor.Instancia.BuscarProveedor(Prov);

        }
        #endregion metodos
    }
}