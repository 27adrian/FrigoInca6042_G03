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
    public class datIngresaMateriaPrima
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datIngresaMateriaPrima _instancia = new datIngresaMateriaPrima();
        //privado para evitar la instanciación directa
        public static datIngresaMateriaPrima Instancia
        {
            get
            {
                return datIngresaMateriaPrima._instancia;
            }
        }
        #endregion singleton
        public List<entIngresaMateriaPrima> ListarMateriaPrima()
        {
            SqlCommand cmd = null;
            List<entIngresaMateriaPrima> lista = new List<entIngresaMateriaPrima>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarMateriaPrima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entIngresaMateriaPrima mp = new entIngresaMateriaPrima();
                    mp.IdIngresomateriaprima = Convert.ToInt32(dr["IdIngresomateriaprima"]);
                    mp.IdOrdencompra = Convert.ToInt32(dr["IdOrdencompra"]);
                    mp.Peso = Convert.ToDecimal(dr["Peso"].ToString());
                    mp.Calidad = dr["Calidad"].ToString();
                    mp.Fecha = Convert.ToDateTime(dr["Fecha"]);
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
        public Boolean InsertarMateriaprima(entIngresaMateriaPrima animal)
        {
            SqlCommand cmd = null;
            Boolean insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarMateriaprima", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOrdencompra", animal.IdOrdencompra);
                cmd.Parameters.AddWithValue("@Peso", animal.Peso);
                cmd.Parameters.AddWithValue("@Calidad", animal.Calidad);
                cmd.Parameters.AddWithValue("@Fecha", animal.Fecha);
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
