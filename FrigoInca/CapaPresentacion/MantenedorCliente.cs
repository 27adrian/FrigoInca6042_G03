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

namespace CapaPresentacion
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            dgv_Cliente.CellClick += Dgv_Cliente_CellClick;
            Listarcliente();
            gb_Cliente.Enabled = false;
            txt_Idcliente.Enabled = false;
        }

        private void Dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // asegura que el usuario haya hecho clic en una fila y no en el encabezado
            {
                DataGridViewRow row = dgv_Cliente.Rows[e.RowIndex];

                // Establece los datos en los controles de texto
                txt_Idcliente.Text = row.Cells["Idcliente"].Value.ToString();
                cb_Tipocliente.Text = row.Cells["Tipocliente"].Value.ToString();
                txt_NombreCompleto.Text = row.Cells["Nombrecompleto"].Value.ToString();
                cb_Tipodocumento.Text = row.Cells["Tipodocumento"].Value.ToString();
                txt_Numerodocumento.Text = row.Cells["Numerodocumento"].Value.ToString();
                txt_Correo.Text = row.Cells["Correo"].Value.ToString();
                txt_Telefonocontacto.Text = row.Cells["Telefonocontacto"].Value.ToString();
                // Para el checkbox, necesitas convertir el valor a booleano.
                cb_Estadodelcliente.Checked = Convert.ToBoolean(row.Cells["Estadocliente"].Value);
                dt_Fecharegistro.Value = Convert.ToDateTime(row.Cells["Fecharegistrocliente"].Value);
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
        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Idcliente = int.Parse(txt_Idcliente.Text.Trim());
                cb_Estadodelcliente.Checked = false;
                c.Estadocliente = cb_Estadodelcliente.Checked;
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
    }
}
