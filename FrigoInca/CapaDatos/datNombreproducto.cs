using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datNombreproducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datNombreproducto _instancia = new datNombreproducto();
        //privado para evitar la instanciación directa
        public static datNombreproducto Instancia
        {
            get
            {
                return datNombreproducto._instancia;
            }
        }
        #endregion singleton
        public List<entNombreproducto> ListarNombreproducto()
        {
            SqlCommand cmd = null;
            List<entNombreproducto> lista = new List<entNombreproducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarNombreproducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNombreproducto animal = new entNombreproducto();
                    animal.IdNombreproducto = Convert.ToInt32(dr["IdNombreproducto"]);
                    animal.Nombreproducto = dr["Nombreproducto"].ToString();
                    animal.Precio = Convert.ToDecimal(dr["Precio"].ToString());

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
        public Boolean InsertarNombreproducto(entNombreproducto ubigeo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarNombreproducto", cn); // Adjust with the correct stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombreproducto", ubigeo.Nombreproducto);
                cmd.Parameters.AddWithValue("@Precio", ubigeo.Precio);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // O utiliza un sistema de registro adecuado
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
    }
}
