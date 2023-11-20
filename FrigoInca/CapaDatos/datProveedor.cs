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
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Proveedores
        public List<entProveedor> Listarproveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("Listarproveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Prov = new entProveedor();
                    Prov.Idproveedor = Convert.ToInt32(dr["Idproveedor"]);
                    Prov.Tipoproveedor = dr["Tipoproveedor"].ToString();
                    Prov.Nombrecompletoproveedor = dr["Nombrecompleto"].ToString();
                    Prov.Tipodocumentoproveedor = dr["Tipodocumento"].ToString();
                    Prov.Numerodocumentoproveedor = Convert.ToInt64(dr["Numerodocumento"]);
                    Prov.Correoproveedor = dr["Correo"].ToString();
                    Prov.Telefonocontactoproveedor = Convert.ToInt32(dr["Telefonocontacto"]);
                    Prov.Estadoproveedor = Convert.ToBoolean(dr["Estadoproveedor"]);
                    Prov.Fecharegistroproveedor = Convert.ToDateTime(dr["Fecharegistroproveedor"]);
                    Prov.IdUbigeo = Convert.ToInt32(dr["IdUbigeo"]);
                    lista.Add(Prov);
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
        /////////////////////////InsertaProveedor
        public Boolean Insertarproveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Insertarproveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipoproveedor", Prov.Tipoproveedor);
                cmd.Parameters.AddWithValue("@Nombrecompleto", Prov.Nombrecompletoproveedor);
                cmd.Parameters.AddWithValue("@Tipodocumento", Prov.Tipodocumentoproveedor);
                cmd.Parameters.AddWithValue("@Numerodocumento", Prov.Numerodocumentoproveedor);
                cmd.Parameters.AddWithValue("@Correo", Prov.Correoproveedor);
                cmd.Parameters.AddWithValue("@Telefonocontacto", Prov.Telefonocontactoproveedor);
                cmd.Parameters.AddWithValue("@Estadoproveedor", Prov.Estadoproveedor);
                cmd.Parameters.AddWithValue("@Fecharegistroproveedor", Prov.Fecharegistroproveedor);
                cmd.Parameters.AddWithValue("@IdUbigeo", Prov.IdUbigeo);
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
        //////////////////////////////////EditaProveedor
        public Boolean Editarproveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Editarproveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idproveedor", Prov.Idproveedor);
                cmd.Parameters.AddWithValue("@Tipoproveedor", Prov.Tipoproveedor);
                cmd.Parameters.AddWithValue("@Nombrecompleto", Prov.Nombrecompletoproveedor);
                cmd.Parameters.AddWithValue("@Tipodocumento", Prov.Tipodocumentoproveedor);
                cmd.Parameters.AddWithValue("@Numerodocumento", Prov.Numerodocumentoproveedor);
                cmd.Parameters.AddWithValue("@Correo", Prov.Correoproveedor);
                cmd.Parameters.AddWithValue("@Telefonocontacto", Prov.Telefonocontactoproveedor);
                cmd.Parameters.AddWithValue("@Estadoproveedor", Prov.Estadoproveedor);
                cmd.Parameters.AddWithValue("@Fecharegistroproveedor", Prov.Fecharegistroproveedor);
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
            finally { cmd.Connection.Close(); }
            return edita;
        }
        //deshabilitaProveedor
        public Boolean Deshabilitarproveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Deshabilitarproveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idproveedor", Prov.Idproveedor);
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
        public List<entProveedor> BuscarProveedor(entProveedor Prov)
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numDoc", Prov.Numerodocumentoproveedor);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor proveedor = new entProveedor(); // Crea un nuevo objeto en cada iteración

                    proveedor.Idproveedor = Convert.ToInt32(dr["Idproveedor"]);
                    proveedor.Tipoproveedor = dr["Tipoproveedor"].ToString();
                    proveedor.Nombrecompletoproveedor = dr["Nombrecompleto"].ToString();
                    proveedor.Tipodocumentoproveedor = dr["Tipodocumento"].ToString();
                    proveedor.Numerodocumentoproveedor = Convert.ToInt64(dr["Numerodocumento"]);
                    proveedor.Correoproveedor = dr["Correo"].ToString();
                    proveedor.Telefonocontactoproveedor = Convert.ToInt32(dr["Telefonocontacto"]);
                    proveedor.Estadoproveedor = Convert.ToBoolean(dr["Estadoproveedor"]);
                    proveedor.Fecharegistroproveedor = Convert.ToDateTime(dr["Fecharegistroproveedor"]);

                    lista.Add(proveedor);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null && cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
            return lista;

            #endregion metodos
        }
    }
}
