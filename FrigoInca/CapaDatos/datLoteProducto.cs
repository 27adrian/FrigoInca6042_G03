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
    public class datLoteProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datLoteProducto _instancia = new datLoteProducto();
        //privado para evitar la instanciación directa
        public static datLoteProducto Instancia
        {
            get
            {
                return datLoteProducto._instancia;
            }
        }
        #endregion singleton

        public List<entLoteProducto> ListarLoteProducto()
        {
            SqlCommand cmd = null;
            List<entLoteProducto> lista = new List<entLoteProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarLoteProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entLoteProducto lp = new entLoteProducto();
                    lp.IdLoteproducto = Convert.ToInt32(dr["IdLoteproducto"]);
                    lp.IdIngresomateriaprima = Convert.ToInt32(dr["IdIngresomateriaprima"]);
                    lp.IdCorte = Convert.ToInt32(dr["IdCorte"]);
                    lp.IdNombreproducto = Convert.ToInt32(dr["IdNombreproducto"]);
                    lp.Peso = Convert.ToDecimal(dr["Peso"]);
                    lp.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    lp.Fechalote = Convert.ToDateTime(dr["Fechalote"]);
                    lista.Add(lp);
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

        public List<entCombo2> ListarComboCarnerDerivado()
        {
            SqlCommand cmd = null;
            List<entCombo2> lista = new List<entCombo2>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarComboCarnerDerivado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCombo2 lp = new entCombo2();
                    lp.IdNombreproducto = Convert.ToInt32(dr["IdNombreproducto"]);
                    lp.Nombreproducto = dr["Nombreproducto"].ToString(); ;
                    lista.Add(lp);
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
        public List<entCombo1> ListarComboCarner()
        {
            SqlCommand cmd = null;
            List<entCombo1> lista = new List<entCombo1>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarComboCarner", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCombo1 lp = new entCombo1();
                    lp.IdCorte = Convert.ToInt32(dr["IdCorte"]);
                    lp.NombreCorte = dr["NombreCorte"].ToString(); ;
                    lista.Add(lp);
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

        public Boolean RestarPeso(int IdIngresomateriaprima, decimal Peso)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RestarPeso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdIngresomateriaprima", IdIngresomateriaprima);
                cmd.Parameters.AddWithValue("@Peso", Peso);
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

        public Boolean RestarCantidad(int IDLoteProducto, int cantidad)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RestarCantidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLoteproducto", IDLoteProducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
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

        public Boolean InsertarLoteProducto(entLoteProducto Lp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarLoteProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdIngresomateriaprima", Lp.IdIngresomateriaprima);
                cmd.Parameters.AddWithValue("@IdCorte", Lp.IdCorte);
                cmd.Parameters.AddWithValue("@IdNombreproducto", Lp.IdNombreproducto);
                cmd.Parameters.AddWithValue("@Peso", Lp.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", Lp.Cantidad);
                cmd.Parameters.AddWithValue("@Fechalote", Lp.Fechalote);
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

        public Boolean InsertarLoteProductoRecursivo(entLoteProducto Lp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarLoteProductoRecursivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdIngresomateriaprima", Lp.IdIngresomateriaprima);
                cmd.Parameters.AddWithValue("@IdCorte", Lp.IdCorte);
                cmd.Parameters.AddWithValue("@IdNombreproducto", Lp.IdNombreproducto);
                cmd.Parameters.AddWithValue("@Peso", Lp.Peso);
                cmd.Parameters.AddWithValue("@Cantidad", Lp.Cantidad);
                cmd.Parameters.AddWithValue("@Fechalote", Lp.Fechalote);
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

        public string RecuperarNombre(int opcion, int IDBusqueda)
        {
            SqlCommand cmd = null;
            string nombreRecuperado = string.Empty;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RecuperarNombreID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opcion", opcion);
                cmd.Parameters.AddWithValue("@IDMateriaPrima", IDBusqueda);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nombreRecuperado = dr["Nombre"].ToString();
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
            return nombreRecuperado;
        }
    }
}
