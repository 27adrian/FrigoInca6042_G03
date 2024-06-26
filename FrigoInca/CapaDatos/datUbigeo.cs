﻿using CapaDatos;
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
    public class datUbigeo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUbigeo _instancia = new datUbigeo();
        //privado para evitar la instanciación directa
        public static datUbigeo Instancia
        {
            get
            {
                return datUbigeo._instancia;
            }
        }
        #endregion singleton
        public List<entUbigeo> ListarUbigeo()
        {
            SqlCommand cmd = null;
            List<entUbigeo> lista = new List<entUbigeo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("ListarUbigeo", cn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUbigeo ubigeo = new entUbigeo();
                    ubigeo.IdUbigeo = Convert.ToInt32(dr["IdUbigeo"]);
                    ubigeo.Departamento = dr["Departamento"].ToString();
                    ubigeo.Provincia = dr["Provincia"].ToString();
                    ubigeo.Distrito = dr["Distrito"].ToString();
                    lista.Add(ubigeo);
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
        public Boolean InsertarUbigeo(entUbigeo ubigeo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarUbigeo", cn); // Adjust with the correct stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUbigeo", ubigeo.IdUbigeo);
                cmd.Parameters.AddWithValue("@Departamento", ubigeo.Departamento);
                cmd.Parameters.AddWithValue("@Provincia", ubigeo.Provincia);
                cmd.Parameters.AddWithValue("@Distrito", ubigeo.Distrito);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // O utiliza un sistema de registro adecuado
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarUbigeo(entUbigeo ubigeo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarUbigeo", cn); // Adjust with the correct stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUbigeo", ubigeo.IdUbigeo);
                cmd.Parameters.AddWithValue("@Departamento", ubigeo.Departamento);
                cmd.Parameters.AddWithValue("@Provincia", ubigeo.Provincia);
                cmd.Parameters.AddWithValue("@Distrito", ubigeo.Distrito);
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
        public Boolean DeshabilitarUbigeo(entUbigeo ubigeo)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarUbigeo", cn); // Usa el nuevo procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUbigeo", ubigeo.IdUbigeo);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return deshabilita;
        }

    }
}
