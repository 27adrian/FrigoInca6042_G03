using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logLoteProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logLoteProducto _instancia = new logLoteProducto();
        //privado para evitar la instanciación directa
        public static logLoteProducto Instancia
        {
            get
            {
                return logLoteProducto._instancia;
            }
        }
        #endregion singleton

        public List<entLoteProducto> ListarLoteProducto()
        {
            return datLoteProducto.Instancia.ListarLoteProducto();
        }

        public List<entCombo1> ListarComboCarner()
        {
            return datLoteProducto.Instancia.ListarComboCarner();
        }

        public List<entCombo2> ListarComboCarnerDerivado()
        {
            return datLoteProducto.Instancia.ListarComboCarnerDerivado();
        }

        public bool RestarPeso(int IdIngresomateriaprima, decimal Peso)
        {
            return datLoteProducto.Instancia.RestarPeso(IdIngresomateriaprima, Peso);
        }

        public bool RestarCantidad(int IDLoteProducto, int cantidad)
        {
            return datLoteProducto.Instancia.RestarCantidad(IDLoteProducto, cantidad);
        }

        public bool InsertarLoteProducto(entLoteProducto lp)
        {
            return datLoteProducto.Instancia.InsertarLoteProducto(lp);
        }

        public bool InsertarLoteProductoRecursivo(entLoteProducto lp)
        {
            return datLoteProducto.Instancia.InsertarLoteProductoRecursivo(lp);
        }

        public string RecuperarNombre(int opcion, int IDBusqueda)
        {
            return datLoteProducto.Instancia.RecuperarNombre(opcion, IDBusqueda);
        }

    }
}
