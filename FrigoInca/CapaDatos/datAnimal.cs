using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datAnimal
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datAnimal _instancia = new datAnimal();
        //privado para evitar la instanciación directa
        public static datAnimal Instancia
        {
            get
            {
                return datAnimal._instancia;
            }
        }
        #endregion singleton
        public List<entAnimal> ListarAnimales()
        {
            SqlCommand cmd = null;
            List<entAnimal> lista = new List<entAnimal>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarAnimal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entAnimal animal = new entAnimal();
                    animal.IdAnimal = Convert.ToInt32(dr["IdAnimal"]);
                    animal.Animal = dr["Animal"].ToString();
                    animal.EstadoAnimal = Convert.ToBoolean(dr["EstadoAnimal"]);
                    lista.Add(animal);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        public Boolean InsertarAnimal(entAnimal animal)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarAnimal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Animal", animal.Animal);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return insertado;
        }
    }
}
