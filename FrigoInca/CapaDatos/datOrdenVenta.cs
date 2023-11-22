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
    public class datOrdenVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdenVenta _instancia = new datOrdenVenta();
        //privado para evitar la instanciación directa
        public static datOrdenVenta Instancia
        {
            get
            {
                return datOrdenVenta._instancia;
            }
        }
        #endregion singleton
        public List<entOrdenVenta> ListarOrdenVenta()
        {
            SqlCommand cmd = null;
            List<entOrdenVenta> lista = new List<entOrdenVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarOrdenventa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenVenta animal = new entOrdenVenta();
                    animal.IdOrdendeventa = Convert.ToInt32(dr["IdOrdendeventa"]);
                    animal.Idloteproducto = Convert.ToInt32(dr["Idloteproducto"]);
                    animal.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    animal.IdDescuento = Convert.ToInt32(dr["IdDescuento"]);
                    animal.IdFormapago = Convert.ToInt32(dr["IdFormapago"]);
                    animal.Estadoventa = Convert.ToBoolean(dr["Estadoventa"]);
                    animal.Fechaventa = Convert.ToDateTime(dr["Fechaventa"]);
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
        public Boolean InsertarOrdenVenta(entOrdenVenta animal)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarOrdenVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idloteproducto", animal.Idloteproducto);
                cmd.Parameters.AddWithValue("@IdCliente", animal.IdCliente);
                cmd.Parameters.AddWithValue("@IdDescuento", animal.IdDescuento);
                cmd.Parameters.AddWithValue("@IdFormapago", animal.IdFormapago);
                cmd.Parameters.AddWithValue("@Estadoventa", animal.Estadoventa);
                cmd.Parameters.AddWithValue("@Fechaventa", animal.Fechaventa);
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
        public Boolean DeshabilitarOrdenVenta(entOrdenVenta Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarOrdenVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrdendeventa", Cli.IdOrdendeventa);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
    }
}
