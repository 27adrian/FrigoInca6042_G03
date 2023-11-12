using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<entCliente> Listarcliente()
        {
            return datCliente.Instancia.Listarcliente();
        }
        ///inserta
        public void Insertarcliente(entCliente Cli)
        {
            datCliente.Instancia.Insertarcliente(Cli);
        }
        //edita
        public void Editarcliente(entCliente Cli)
        {
            datCliente.Instancia.Editarcliente(Cli);
        }
        public void Deshabilitarcliente(entCliente Cli)
        {
            datCliente.Instancia.Deshabilitarcliente(Cli);
        }

        public List<entProveedor> BuscarProveedor(entProveedor Prov)
        {
            return datProveedor.Instancia.BuscarProveedor(Prov);

        }
        #endregion metodos
    }
}
