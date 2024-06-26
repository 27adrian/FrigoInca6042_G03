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
                    Cli.Nombrecompletocliente = dr["Nombrecliente"].ToString();
                    Cli.Tipodocumentocliente = dr["Tipodocumento"].ToString();
                    Cli.Numerodocumentocliente = Convert.ToInt64(dr["Numerodocumento"]);
                    Cli.Correocliente = dr["Correo"].ToString();
                    Cli.Telefonocontactocliente = Convert.ToInt32(dr["Telefono"]);
                    Cli.Estadocliente = Convert.ToBoolean(dr["Estado"]);
                    Cli.Fecharegistrocliente = Convert.ToDateTime(dr["Fecharegistrocliente"]);
                    Cli.IdUbigeo = Convert.ToInt32(dr["IdUbigeo"]);
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
                cmd.Parameters.AddWithValue("@Nombrecliente", Cli.Nombrecompletocliente);
                cmd.Parameters.AddWithValue("@Tipodocumento", Cli.Tipodocumentocliente);
                cmd.Parameters.AddWithValue("@Numerodocumento", Cli.Numerodocumentocliente);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correocliente);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefonocontactocliente);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estadocliente);
                cmd.Parameters.AddWithValue("@Fecharegistrocliente", Cli.Fecharegistrocliente);
                cmd.Parameters.AddWithValue("@IdUbigeo", Cli.IdUbigeo);

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
        public Boolean Editarcliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Editarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", Cli.Idcliente);
                cmd.Parameters.AddWithValue("@Tipocliente", Cli.Tipocliente);
                cmd.Parameters.AddWithValue("@Nombrecliente", Cli.Nombrecompletocliente);
                cmd.Parameters.AddWithValue("@Tipodocumento", Cli.Tipodocumentocliente);
                cmd.Parameters.AddWithValue("@Numerodocumento", Cli.Numerodocumentocliente);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correocliente);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefonocontactocliente);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estadocliente);
                cmd.Parameters.AddWithValue("@Fecharegistrocliente", Cli.Fecharegistrocliente);
                cmd.Parameters.AddWithValue("@IdUbigeo", Cli.IdUbigeo);
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
        public Boolean Deshabilitarcliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Deshabilitarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idcliente", Cli.Idcliente);
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

        public List<entCliente> BuscarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Numerodocumento", Cli.Numerodocumentocliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cliente = new entCliente(); // Crea un nuevo objeto en cada iteración

                    Cliente.Idcliente = Convert.ToInt32(dr["Idcliente"]);
                    Cliente.Tipocliente = dr["Tipocliente"].ToString();
                    Cliente.Nombrecompletocliente = dr["Nombrecliente"].ToString();
                    Cliente.Tipodocumentocliente = dr["Tipodocumento"].ToString();
                    Cliente.Numerodocumentocliente = Convert.ToInt64(dr["Numerodocumento"]);
                    Cliente.Correocliente = dr["Correo"].ToString();
                    Cliente.Telefonocontactocliente = Convert.ToInt32(dr["Telefono"]);
                    Cliente.Estadocliente = Convert.ToBoolean(dr["Estado"]);
                    Cliente.Fecharegistrocliente = Convert.ToDateTime(dr["Fecharegistrocliente"]);
                    Cliente.IdUbigeo = Convert.ToInt32(dr["IdUbigeo"]);
                    lista.Add(Cliente);
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