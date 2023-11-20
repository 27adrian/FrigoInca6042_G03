using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CapaPresentacion
{
    public partial class Mantenedor_Cliente : Form
    {
        public Mantenedor_Cliente()
        {
            InitializeComponent();
            dgv_Cliente.CellClick += new DataGridViewCellEventHandler(dgv_Cliente_CellClick);
            Listarcliente();
            gb_Cliente.Enabled = false;
            txt_Idcliente.Enabled = false;
        }

        private void dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_Cliente.Rows[e.RowIndex];

                txt_Idcliente.Text = row.Cells[0].Value?.ToString();
                cb_Tipocliente.Text = row.Cells[1].Value?.ToString();
                txt_NombreCompleto.Text = row.Cells[2].Value?.ToString();
                cb_Tipodocumento.Text = row.Cells[3].Value?.ToString();
                txt_Numerodocumento.Text = row.Cells[4].Value?.ToString();
                txt_Correo.Text = row.Cells[5].Value?.ToString();
                txt_Telefonocontacto.Text = row.Cells[6].Value?.ToString();
                cb_Estadodelcliente.Checked = Convert.ToBoolean(row.Cells[7].Value);
                dt_Fecharegistro.Value = Convert.ToDateTime(row.Cells[8].Value);
            }
        }



        public void Listarcliente()
        {
            dgv_Cliente.DataSource = logCliente.Instancia.Listarcliente();
        }
        private void LimpiarVariables()
        {
            cb_Tipocliente.Text = " ";
            txt_NombreCompleto.Text = " ";
            cb_Tipodocumento.Text = " ";
            txt_Numerodocumento.Text = " "; 
            txt_Correo.Text = " ";
            txt_Telefonocontacto.Text = " ";
        }

        private void MantenedorCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            gb_Cliente.Enabled = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gb_Cliente.Enabled = true;

            btn_Agregar.Visible = true;
            LimpiarVariables();
            btn_Modificar.Visible = false;
        }

        private void gb_Cliente_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Tipocliente = cb_Tipocliente.Text.Trim();
                c.Nombrecompletocliente = txt_NombreCompleto.Text.Trim();
                c.Tipodocumentocliente = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentocliente = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correocliente = txt_Correo.Text.Trim();
                c.Telefonocontactocliente = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadocliente = cb_Estadodelcliente.Checked;
                c.Fecharegistrocliente = dt_Fecharegistro.Value;
                logCliente.Instancia.Insertarcliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Cliente.Enabled = false;
            Listarcliente();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            gb_Cliente.Enabled = true;
            btn_Modificar.Visible = true;
            btn_Agregar.Visible = false;
            cb_Estadodelcliente.Enabled = false;
        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Idcliente = int.Parse(txt_Idcliente.Text.Trim());
                logCliente.Instancia.Deshabilitarcliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Cliente.Enabled = false;
            Listarcliente();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Idcliente = int.Parse(txt_Idcliente.Text.Trim());
                c.Tipocliente = cb_Tipocliente.Text.Trim();
                c.Nombrecompletocliente = txt_NombreCompleto.Text.Trim();
                c.Tipodocumentocliente = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentocliente = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correocliente = txt_Correo.Text.Trim();
                c.Telefonocontactocliente = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadocliente = cb_Estadodelcliente.Checked;
                c.Fecharegistrocliente = dt_Fecharegistro.Value;
                logCliente.Instancia.Editarcliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Cliente.Enabled = false;
            Listarcliente();
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Numerodocumentocliente = int.Parse(txtNumDoc1.Text.Trim());
                List<entCliente> listaCliente = logCliente.Instancia.BuscarCliente(c);

                if (listaCliente.Count > 0)
                {
                    MostrarInformacionCliente(listaCliente[0]);

                    DataGridViewRow row = BuscarFilaPorNumeroDocumento(txtNumDoc1.Text.Trim());

                    if (row != null)
                    {
                        dgv_Cliente.CurrentCell = row.Cells[0];
                        dgv_Cliente.Rows[row.Index].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún Cliente con el número de documento proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        private void MostrarInformacionCliente(entCliente Cli)
        {
            txt_Idcliente.Text = Cli.Idcliente.ToString();
            cb_Tipocliente.Text = Cli.Tipocliente;
            txt_NombreCompleto.Text = Cli.Nombrecompletocliente;
            cb_Tipodocumento.Text = Cli.Tipodocumentocliente;
            txt_Numerodocumento.Text = Cli.Numerodocumentocliente.ToString();
            txt_Correo.Text = Cli.Correocliente;
            txt_Telefonocontacto.Text = Cli.Telefonocontactocliente.ToString();
            cb_Estadodelcliente.Checked = Cli.Estadocliente;
            dt_Fecharegistro.Value = Cli.Fecharegistrocliente;
            txtNumDoc1.Text = Cli.Numerodocumentocliente.ToString();
        }

        private DataGridViewRow BuscarFilaPorNumeroDocumento(string numeroDocumento)
        {
            foreach (DataGridViewRow row in dgv_Cliente.Rows)
            {
                if (row.Cells["NumerodocumentoCliente"].Value.ToString() == numeroDocumento)
                {
                    return row;
                }
            }

            return null;
        }
    }
}
