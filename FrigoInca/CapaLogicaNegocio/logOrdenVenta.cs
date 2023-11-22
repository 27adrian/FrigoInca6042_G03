using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logOrdenVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdenVenta _instancia = new logOrdenVenta();
        //privado para evitar la instanciación directa
        public static logOrdenVenta Instancia
        {
            get
            {
                return logOrdenVenta._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entOrdenVenta> ListarOrdenVenta()
        {
            return datOrdenVenta.Instancia.ListarOrdenVenta();
        }
        ///inserta
        public void InsertarOrdenVenta(entOrdenVenta animal)
        {
            datOrdenVenta.Instancia.InsertarOrdenVenta(animal);
        }
        public void DeshabilitarOrdenVenta(entOrdenVenta Cli)
        {
            datOrdenVenta.Instancia.DeshabilitarOrdenVenta(Cli);
        }
        public entOrdenVenta BuscarOrdenVenta(int IdOrdendeventa)
        {
            return datOrdenVenta.Instancia.BuscarOrdenVenta(IdOrdendeventa);
        }

    }
}
