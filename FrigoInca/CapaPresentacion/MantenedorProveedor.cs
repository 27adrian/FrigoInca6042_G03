using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            dgv_Proveedor.CellClick += new DataGridViewCellEventHandler(dgv_Proveedor_CellClick);
            Listarproveedor();
            gb_Proveedor.Enabled = false;
            txt_Idproveedor.Enabled = false;
        }
        private void dgv_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_Proveedor.Rows[e.RowIndex];

                txt_Idproveedor.Text = row.Cells[0].Value?.ToString();
                cb_Tipoproveedor.Text = row.Cells[1].Value?.ToString();
                txt_Nombrecompleto.Text = row.Cells[2].Value?.ToString();
                cb_Tipodocumento.Text = row.Cells[3].Value?.ToString();
                txt_Numerodocumento.Text = row.Cells[4].Value?.ToString();
                txt_Correo.Text = row.Cells[5].Value?.ToString();
                txt_Telefonocontacto.Text = row.Cells[6].Value?.ToString();
                cb_Estadodelproveedor.Checked = Convert.ToBoolean(row.Cells[7].Value);
                dt_Fechaderegistroproveedor.Value = Convert.ToDateTime(row.Cells[8].Value);
            }
        }

        public void Listarproveedor()
        {
            dgv_Proveedor.DataSource = logProveedor.Instancia.Listarproveedor();
        }
        private void LimpiarVariables()
        {
            cb_Tipoproveedor.Text = " ";
            txt_Nombrecompleto.Text = " ";
            cb_Tipodocumento.Text = " ";
            txt_Numerodocumento.Text = " ";
            txt_Correo.Text = " ";
            txt_Telefonocontacto.Text = " ";
        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gb_Proveedor.Enabled = true;

            btn_Agregar.Visible = true;
            LimpiarVariables();
            btn_Modificar.Visible = false;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            gb_Proveedor.Enabled = true;
            btn_Modificar.Visible = true;
            btn_Agregar.Visible = false;
        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.Idproveedor = int.Parse(txt_Idproveedor.Text.Trim());
                logProveedor.Instancia.Deshabilitarproveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Proveedor.Enabled = false;
            Listarproveedor();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.Tipoproveedor = cb_Tipoproveedor.Text.Trim();
                c.Nombrecompletoproveedor = txt_Nombrecompleto.Text.Trim();
                c.Tipodocumentoproveedor = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentoproveedor = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correoproveedor = txt_Correo.Text.Trim();
                c.Telefonocontactoproveedor = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadoproveedor = cb_Estadodelproveedor.Checked;
                c.Fecharegistroproveedor = dt_Fechaderegistroproveedor.Value;
                logProveedor.Instancia.Insertarproveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Proveedor.Enabled = false;
            Listarproveedor();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.Idproveedor = int.Parse(txt_Idproveedor.Text.Trim());
                c.Tipoproveedor = cb_Tipoproveedor.Text.Trim();
                c.Nombrecompletoproveedor = txt_Nombrecompleto.Text.Trim();
                c.Tipodocumentoproveedor = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentoproveedor = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correoproveedor = txt_Correo.Text.Trim();
                c.Telefonocontactoproveedor = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadoproveedor = cb_Estadodelproveedor.Checked;
                c.Fecharegistroproveedor = dt_Fechaderegistroproveedor.Value;
                logProveedor.Instancia.Editarproveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Proveedor.Enabled = false;
            Listarproveedor();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gb_Proveedor.Enabled = false;
        }
    }
}
