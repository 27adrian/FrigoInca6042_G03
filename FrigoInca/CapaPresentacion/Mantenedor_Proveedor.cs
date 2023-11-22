using CapaEntidad;
using CapaLogicaNegocio;
using FrigoInca;
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
    public partial class Mantenedor_Proveedor : Form
    {
        public Mantenedor_Proveedor()
        {
            InitializeComponent();
            dgvUbigeo.CellClick += new DataGridViewCellEventHandler(dgvUbigeo_CellClick);
            Listarproveedor();
            CargarAnimalesEnComboBox();
            ListarUbigeo();
            gb_Proveedor.Enabled = false;
            txt_Idproveedor.Enabled = false;
        }
        public void ListarUbigeo()
        {
            dgvUbigeo.DataSource = logUbigeo.Instancia.ListarUbigeo();
        }
        private void dgvUbigeo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is not the header and not -1 (no selection)
            if (e.RowIndex >= 0)
            {
                // Assuming the ID is in the first column, index 0
                string id = dgvUbigeo.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Set the ID to your TextBox
                txtIdUbigeo.Text = id;
            }
        }

        private void CargarAnimalesEnComboBox()
        {
            List<entAnimal> listaAnimales = logAnimal.Instancia.ListarAnimal();
            cbAnimal.DataSource = listaAnimales;
            cbAnimal.DisplayMember = "Animal"; // El nombre del animal para mostrar en el ComboBox
            cbAnimal.ValueMember = "IdAnimal"; // El valor real que representa al animal (su ID)
        }

        public void Listarproveedor()
        {
            dgv_Proveedor.DataSource = logProveedor.Instancia.Listarproveedor();
            nombresColumnas();
        }
        public void nombresColumnas()
        {
            dgv_Proveedor.Columns[0].HeaderText = "ID";
            dgv_Proveedor.Columns[1].HeaderText = "Tipo";
            dgv_Proveedor.Columns[2].HeaderText = "Nombre";
            dgv_Proveedor.Columns[3].HeaderText = "Animal";
            dgv_Proveedor.Columns[4].HeaderText = "Tipo Documento";
            dgv_Proveedor.Columns[5].HeaderText = "Num Documento";
            dgv_Proveedor.Columns[6].HeaderText = "Correo";
            dgv_Proveedor.Columns[7].HeaderText = "Telefono";
            dgv_Proveedor.Columns[8].HeaderText = "Estado";
            dgv_Proveedor.Columns[9].HeaderText = "Fecha Registro";
            dgv_Proveedor.Columns[10].HeaderText = "Ubigeo";
        }
        private void LimpiarVariables()
        {
            txt_Idproveedor.Text = "";
            txt_Nombrecompleto.Text = "";
            txt_Numerodocumento.Text = "";
            txt_Correo.Text = "";
            txt_Telefonocontacto.Text = "";
            txtIdUbigeo.Text = "";
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            BloqDesbloqBotones(false);
            cb_Estadodelproveedor.Enabled = false;
            gb_Proveedor.Enabled = true;
            txtIdUbigeo.Enabled = false;
            btn_Agregar.Visible = true;
            LimpiarVariables();
            btn_Modificar.Visible = false;
            dgv_Proveedor.CellEnter -= dgv_Proveedor_CellEnter;
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            BloqDesbloqBotones(false);
            cb_Estadodelproveedor.Enabled = true;
            gb_Proveedor.Enabled = true;
            btn_Modificar.Visible = true;
            btn_Agregar.Visible = false;
            dgv_Proveedor.CellEnter -= dgv_Proveedor_CellEnter;
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
                c.Animal = cbAnimal.Text.Trim();
                c.Tipodocumentoproveedor = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentoproveedor = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correoproveedor = txt_Correo.Text.Trim();
                c.Telefonocontactoproveedor = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadoproveedor = cb_Estadodelproveedor.Checked;
                c.Fecharegistroproveedor = dt_Fechaderegistroproveedor.Value;
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                //logProveedor.Instancia.Insertarproveedor(c);
                if (logProveedor.Instancia.Insertarproveedor(c))
                {
                    MessageBox.Show("Ingreso correcto de datos.", "CONFIRMACION INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgv_Proveedor.CellEnter += dgv_Proveedor_CellEnter;
                BloqDesbloqBotones(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_Proveedor.Enabled = false;
            Listarproveedor();
        }

        private void BloqDesbloqBotones(bool estado)
        {
            btn_Nuevo.Enabled = estado;
            Btn_Editar.Enabled = estado;
            btn_Deshabilitar.Enabled = estado;
            txtNumDoc.Enabled = estado;
            btnBuscar.Enabled = estado;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.Idproveedor = int.Parse(txt_Idproveedor.Text.Trim());
                c.Tipoproveedor = cb_Tipoproveedor.Text.Trim();
                c.Nombrecompletoproveedor = txt_Nombrecompleto.Text.Trim();
                c.Animal = cbAnimal.Text.Trim();
                c.Tipodocumentoproveedor = cb_Tipodocumento.Text.Trim();
                c.Numerodocumentoproveedor = long.Parse(txt_Numerodocumento.Text.Trim());
                c.Correoproveedor = txt_Correo.Text.Trim();
                c.Telefonocontactoproveedor = int.Parse(txt_Telefonocontacto.Text.Trim());
                c.Estadoproveedor = cb_Estadodelproveedor.Checked;
                c.Fecharegistroproveedor = dt_Fechaderegistroproveedor.Value;
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                logProveedor.Instancia.Editarproveedor(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            dgv_Proveedor.CellEnter += dgv_Proveedor_CellEnter;
            LimpiarVariables();
            gb_Proveedor.Enabled = false;
            Listarproveedor();
            BloqDesbloqBotones(true);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gb_Proveedor.Enabled = false;
            dgv_Proveedor.CellEnter += dgv_Proveedor_CellEnter;
            BloqDesbloqBotones(true);
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor c = new entProveedor();
                c.Numerodocumentoproveedor = int.Parse(txtNumDoc.Text.Trim());
                List<entProveedor> listaProveedores = logProveedor.Instancia.BuscarProveedor(c);

                if (listaProveedores.Count > 0)
                {
                    MostrarInformacionProveedor(listaProveedores[0]);

                    DataGridViewRow row = BuscarFilaPorNumeroDocumento(txtNumDoc.Text.Trim());

                    if (row != null)
                    {
                        dgv_Proveedor.CurrentCell = row.Cells[0];
                        dgv_Proveedor.Rows[row.Index].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún proveedor con el número de documento proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.. " + ex.Message);
            }
        }

        private void MostrarInformacionProveedor(entProveedor proveedor)
        {
            txt_Idproveedor.Text = proveedor.Idproveedor.ToString();
            cb_Tipoproveedor.Text = proveedor.Tipoproveedor;
            txt_Nombrecompleto.Text = proveedor.Nombrecompletoproveedor;
            cb_Tipodocumento.Text = proveedor.Tipodocumentoproveedor;
            txt_Numerodocumento.Text = proveedor.Numerodocumentoproveedor.ToString();
            txt_Correo.Text = proveedor.Correoproveedor;
            txt_Telefonocontacto.Text = proveedor.Telefonocontactoproveedor.ToString();
            cb_Estadodelproveedor.Checked = proveedor.Estadoproveedor;
            dt_Fechaderegistroproveedor.Value = proveedor.Fecharegistroproveedor;
            txtNumDoc.Text = proveedor.Numerodocumentoproveedor.ToString();

        }

        private DataGridViewRow BuscarFilaPorNumeroDocumento(string numeroDocumento)
        {
            foreach (DataGridViewRow row in dgv_Proveedor.Rows)
            {
                if (row.Cells["Numerodocumentoproveedor"].Value.ToString() == numeroDocumento)
                {
                    return row;
                }
            }

            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenedor_Ubigeo fcp = new Mantenedor_Ubigeo();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void dgv_Proveedor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv_Proveedor.Rows[e.RowIndex];

                    txt_Idproveedor.Text = row.Cells[0].Value?.ToString();
                    cb_Tipoproveedor.Text = row.Cells[1].Value?.ToString();
                    txt_Nombrecompleto.Text = row.Cells[2].Value?.ToString();
                    cbAnimal.Text = row.Cells[3].Value?.ToString();
                    cb_Tipodocumento.Text = row.Cells[4].Value?.ToString();
                    txt_Numerodocumento.Text = row.Cells[5].Value?.ToString();
                    txt_Correo.Text = row.Cells[6].Value?.ToString();
                    txt_Telefonocontacto.Text = row.Cells[7].Value?.ToString();
                    cb_Estadodelproveedor.Checked = Convert.ToBoolean(row.Cells[8].Value);
                    dt_Fechaderegistroproveedor.Value = Convert.ToDateTime(row.Cells[9].Value);
                    txtIdUbigeo.Text = row.Cells[10].Value?.ToString();
                }
            }
            catch { }

        }

        

        private void cb_Tipoproveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_Tipoproveedor.SelectedIndex == 0)
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