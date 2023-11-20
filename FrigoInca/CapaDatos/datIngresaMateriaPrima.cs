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
                    mp.IdIngresaMateriaPrima = Convert.ToInt32(dr["IdIngresaMateriaPrima"]);
                    mp.IdOrdenCompra = Convert.ToInt32(dr["IdOrdenCompra"]);
                    mp.Proveedor = dr["Proveedor"].ToString();
                    mp.MateriaPrima = dr["MateriaPrima"].ToString();
                    mp.Peso = dr["Peso"].ToString();
                    mp.RegistroIngresoMP = Convert.ToDateTime(dr["RegistroIngresoMP"]);
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
    }
}
