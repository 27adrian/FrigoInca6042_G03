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
    public class datCorte
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCorte _instancia = new datCorte();
        //privado para evitar la instanciación directa
        public static datCorte Instancia
        {
            get
            {
                return datCorte._instancia;
            }
        }
        #endregion singleton
        public List<entCorte> ListarCorte()
        {
            SqlCommand cmd = null;
            List<entCorte> lista = new List<entCorte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarCorte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCorte animal = new entCorte();
                    animal.IdCorte = Convert.ToInt32(dr["IdCorte"]);
                    animal.NombreCorte = dr["NombreCorte"].ToString();
                    animal.Preciocorte = Convert.ToDecimal(dr["Preciocorte"].ToString());

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
        public Boolean InsertarCorte(entCorte corte)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarCorte", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombrecorte", corte.NombreCorte);
                cmd.Parameters.AddWithValue("@Preciocorte", corte.Preciocorte);
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
