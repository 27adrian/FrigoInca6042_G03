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
    public class datDescuento
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDescuento _instancia = new datDescuento();
        //privado para evitar la instanciación directa
        public static datDescuento Instancia
        {
            get
            {
                return datDescuento._instancia;
            }
        }
        #endregion singleton
        public List<entDescuento> ListarDescuento()
        {
            SqlCommand cmd = null;
            List<entDescuento> lista = new List<entDescuento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDescuento animal = new entDescuento();
                    animal.IdDescuento = Convert.ToInt32(dr["IdDescuento"]);
                    animal.Porcentaje = Convert.ToDecimal(dr["Porcentaje"].ToString());
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
        public Boolean InsertarDescuento(entDescuento descuento)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Porcentaje", descuento.Porcentaje);

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
