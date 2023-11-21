using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logAnimal
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logAnimal _instancia = new logAnimal();
        //privado para evitar la instanciación directa
        public static logAnimal Instancia
        {
            get
            {
                return logAnimal._instancia;
            }
        }
        #endregion singleton
        ///listado
        public List<entAnimal> ListarAnimal()
        {
            return datAnimal.Instancia.ListarAnimales();
        }
        ///inserta
        public void InsertarAnimal(entAnimal animal)
        {
            datAnimal.Instancia.InsertarAnimal(animal);
        }
    }
}
