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
    public class datRequerimientocompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datRequerimientocompra _instancia = new datRequerimientocompra();
        //privado para evitar la instanciación directa
        public static datRequerimientocompra Instancia
        {
            get
            {
                return datRequerimientocompra._instancia;
            }
        }
        #endregion singleton
        public List<entRequerimientocompra> ListarRequerimientosCompra()
        {
            SqlCommand cmd = null;
            List<entRequerimientocompra> lista = new List<entRequerimientocompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimientocompra req = new entRequerimientocompra();
                    req.IdRequerimientocompra = Convert.ToInt32(dr["IdRequerimientocompra"]);
                    req.IdAnimal = Convert.ToInt32(dr["IdAnimal"]);
                    req.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    lista.Add(req);
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
        public bool InsertarRequerimientoCompra(entRequerimientocompra req)
        {
            SqlCommand cmd = null;
            bool insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAnimal", req.IdAnimal);
                cmd.Parameters.AddWithValue("@Cantidad", req.Cantidad);

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
        public Boolean EditarRequerimientoCompra(entRequerimientocompra MP)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarCantidadRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdRequerimientocompra", MP.IdRequerimientocompra); // Asegúrate de tener esta propiedad en tu entidad
                cmd.Parameters.AddWithValue("@NuevaCantidad", MP.Cantidad);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }
    }
}
