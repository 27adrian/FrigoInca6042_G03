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
            Listarcliente();
            gb_Cliente.Enabled = false;
            txt_Idcliente.Enabled = false;
        }
        public void Listarcliente()
        {
            dgv_Cliente.DataSource = logCliente.Instancia.ListarCliente();
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
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
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
                c.idCliente = int.Parse(txt_Idcliente.Text.Trim());
                cb_Estadodelcliente.Checked = false;
                c.estCliente = cb_Estadodelcliente.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
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
    }
}
