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
            dgvUbigeo.CellClick += new DataGridViewCellEventHandler(dgvUbigeo_CellClick);
            ListarUbigeo();
            Listarcliente();
            gb_Cliente.Enabled = false;
            txt_Idcliente.Enabled = false;
            cb_Estadodelcliente.Checked = true;
        }
        private void dgvUbigeo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvUbigeo.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtIdUbigeo.Text = id;
            }
        }
        public void ListarUbigeo()
        {
            dgvUbigeo.DataSource = logUbigeo.Instancia.ListarUbigeo();
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
                txtIdUbigeo.Text = row.Cells[9].Value?.ToString();
            }
        }
        public void Listarcliente()
        {
            dgv_Cliente.DataSource = logCliente.Instancia.Listarcliente();
            nombresColumnas();
        }
        public void nombresColumnas()
        {
            dgv_Cliente.Columns[0].HeaderText = "ID";
            dgv_Cliente.Columns[1].HeaderText = "Tipo";
            dgv_Cliente.Columns[2].HeaderText = "Nombre";
            dgv_Cliente.Columns[3].HeaderText = "Tipo Documento";
            dgv_Cliente.Columns[4].HeaderText = "Num Documento";
            dgv_Cliente.Columns[5].HeaderText = "Correo";
            dgv_Cliente.Columns[6].HeaderText = "Telefono";
            dgv_Cliente.Columns[7].HeaderText = "Estado";
            dgv_Cliente.Columns[8].HeaderText = "Fecha Registro";
            dgv_Cliente.Columns[9].HeaderText = "Ubigeo";
        }

        private void LimpiarVariables()
        {
            txt_Idcliente.Text = "";
            txt_NombreCompleto.Text = "";
            txt_Numerodocumento.Text = "";
            txt_Correo.Text = "";
            txt_Telefonocontacto.Text = "";
            txtIdUbigeo.Text = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            gb_Cliente.Enabled = false;
            dgv_Cliente.CellEnter += dgv_Cliente_CellEnter;
            BloqDesbloqBotones(true);
        }

        private void BloqDesbloqBotones(bool estado)
        {
            btn_Nuevo.Enabled = estado;
            btn_Editar.Enabled = estado;
            btn_Deshabilitar.Enabled = estado;
            txtNumDoc1.Enabled = estado;
            btnBuscar.Enabled = estado;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            BloqDesbloqBotones(false);
            cb_Estadodelcliente.Enabled = false;
            gb_Cliente.Enabled = true;
            txtIdUbigeo.Enabled = false;
            btn_Agregar.Visible = true;
            LimpiarVariables();
            btn_Modificar.Visible = false;
            dgv_Cliente.CellEnter -= dgv_Cliente_CellEnter;
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
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                if (logCliente.Instancia.Insertarcliente(c))
                {
                    MessageBox.Show("Ingreso correcto de datos.", "CONFIRMACION INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgv_Cliente.CellEnter += dgv_Cliente_CellEnter;
                BloqDesbloqBotones(true);
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
            BloqDesbloqBotones(false);
            cb_Estadodelcliente.Enabled = true;
            gb_Cliente.Enabled = true;
            btn_Modificar.Visible = true;
            btn_Agregar.Visible = false;
            dgv_Cliente.CellEnter -= dgv_Cliente_CellEnter;
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
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                logCliente.Instancia.Editarcliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            dgv_Cliente.CellEnter += dgv_Cliente_CellEnter;
            LimpiarVariables();
            gb_Cliente.Enabled = false;
            Listarcliente();
            BloqDesbloqBotones(true);
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

        private void dgv_Cliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    txtIdUbigeo.Text = row.Cells[9].Value?.ToString();
                }
            }
            catch { }
        }


        private void dgv_Cliente_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    txtIdUbigeo.Text = row.Cells[9].Value?.ToString();
                }
            }
            catch { }
        }

        private void cb_Tipocliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_Tipocliente.SelectedIndex == 0)
            {
                cb_Tipodocumento.SelectedIndex = 0;
                txt_Numerodocumento.MaxLength = 11;
                txt_Numerodocumento.Text = "";
            }
            else
            {
                cb_Tipodocumento.SelectedIndex = 1;
                txt_Numerodocumento.MaxLength = 8;
                txt_Numerodocumento.Text = "";
            }
        }
    }
}