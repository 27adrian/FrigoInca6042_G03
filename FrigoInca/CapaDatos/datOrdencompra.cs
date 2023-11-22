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
    public class datOrdencompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdencompra _instancia = new datOrdencompra();
        //privado para evitar la instanciación directa
        public static datOrdencompra Instancia
        {
            get
            {
                return datOrdencompra._instancia;
            }
        }
        #endregion singleton
        public List<entOrdencompra> ListarOrdencompra()
        {
            SqlCommand cmd = null;
            List<entOrdencompra> lista = new List<entOrdencompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarOrdencompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdencompra animal = new entOrdencompra();
                    animal.IdOrdencompra = Convert.ToInt32(dr["IdOrdencompra"]);
                    animal.IdProveedor = Convert.ToInt32(dr["IdProveedor"]);
                    animal.IdFormapago = Convert.ToInt32(dr["IdFormapago"]);
                    animal.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    animal.Fechacompra = Convert.ToDateTime(dr["Fechacompra"]);
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
        public Boolean InsertarOrdencompra(entOrdencompra animal)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarOrdencompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProveedor", animal.IdProveedor);
                cmd.Parameters.AddWithValue("@IdFormapago", animal.IdFormapago);
                cmd.Parameters.AddWithValue("@Cantidad", animal.Cantidad);
                cmd.Parameters.AddWithValue("@Fechacompra", animal.Fechacompra);
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
