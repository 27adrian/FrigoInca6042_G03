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
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> Listarcliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("Listarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.Idcliente = Convert.ToInt32(dr["Idcliente"]);
                    Cli.Tipocliente = dr["Tipocliente"].ToString();
                    Cli.Nombrecompleto = dr["Nombrecompleto"].ToString();
                    Cli.Tipodocumento = dr["Tipodocumento"].ToString();
                    Cli.Numerodocumento = Convert.ToInt32(dr["Numerodocumento"]);
                    Cli.Correo = dr["Correo"].ToString();
                    Cli.Telefonocontacto = Convert.ToInt32(dr["Telefonocontacto"]);
                    Cli.Estadocliente = Convert.ToBoolean(dr["Estadocliente"]);
                    Cli.Fecharegistrocliente = Convert.ToDateTime(dr["Fecharegistrocliente"]);
                    lista.Add(Cli);
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
        /////////////////////////InsertaCliente
        public Boolean Insertarcliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Insertarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipocliente", Cli.Tipocliente);
                cmd.Parameters.AddWithValue("@Nombrecompleto", Cli.Nombrecompleto);
                cmd.Parameters.AddWithValue("@Tipodocumento", Cli.Tipodocumento);
                cmd.Parameters.AddWithValue("@Numerodocumento", Cli.Numerodocumento);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Telefonocontacto", Cli.Telefonocontacto);
                cmd.Parameters.AddWithValue("@Estadocliente", Cli.Estadocliente);
                cmd.Parameters.AddWithValue("@Fecharegistrocliente", Cli.Fecharegistrocliente);
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
        //////////////////////////////////EditaCliente
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", Cli.Idcliente);
                cmd.Parameters.AddWithValue("@Tipocliente", Cli.Tipocliente);
                cmd.Parameters.AddWithValue("@Nombrecompleto", Cli.Nombrecompleto);
                cmd.Parameters.AddWithValue("@Tipodocumento", Cli.Tipodocumento);
                cmd.Parameters.AddWithValue("@Numerodocumento", Cli.Numerodocumento);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Telefonocontacto", Cli.Telefonocontacto);
                cmd.Parameters.AddWithValue("@Estadocliente", Cli.Estadocliente);
                cmd.Parameters.AddWithValue("@Fecharegistrocliente", Cli.Fecharegistrocliente);
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
        //deshabilitaCliente
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", Cli.Idcliente);
                cmd.Parameters.AddWithValue("@Estadocliente", Cli.Estadocliente);
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
        #endregion metodos
    }
}
