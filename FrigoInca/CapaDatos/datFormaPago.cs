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
    public class datFormaPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datFormaPago _instancia = new datFormaPago();
        //privado para evitar la instanciación directa
        public static datFormaPago Instancia
        {
            get
            {
                return datFormaPago._instancia;
            }
        }
        #endregion singleton
        public List<entFormaPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entFormaPago> lista = new List<entFormaPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarFormaPago", cn); // Adjust the stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entFormaPago mp = new entFormaPago();
                    mp.IdFormapago = Convert.ToInt32(dr["IdFormapago"]);
                    mp.NombreFp = dr["NombreFp"].ToString();

                    lista.Add(mp);
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
        public Boolean InsertarMetodoPago(entFormaPago mp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarFormaPago", cn); // Use the correct stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreFp", mp.NombreFp);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

    }
}
