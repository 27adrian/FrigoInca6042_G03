using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logIngresaMateriaPrima
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logIngresaMateriaPrima _instancia = new logIngresaMateriaPrima();
        //privado para evitar la instanciación directa
        public static logIngresaMateriaPrima Instancia
        {
            get
            {
                return logIngresaMateriaPrima._instancia;
            }
        }
        #endregion singleton

        public List<entIngresaMateriaPrima> ListarMateriaPrima()
        {
            return datIngresaMateriaPrima.Instancia.ListarMateriaPrima();
        }
        public void InsertarMateriaprima(entIngresaMateriaPrima animal)
        {
            datIngresaMateriaPrima.Instancia.InsertarMateriaprima(animal);
        }
    }
}
