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

namespace FrigoInca
{
    public partial class Core_OrdendeVenta : Form
    {
        public Core_OrdendeVenta()
        {
            InitializeComponent();
            ListarOrdenVenta();
            LlenarCliente();
            LlenarDescuento();
            LlenarFormapago();
            dgvOrdenventa.CellClick += dgvOrdenventa_CellClick;
            cbEstadoventa.Checked = true;
            txtIdOrdendeventa.Enabled = false;

        }
        private void dgvOrdenventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrdenventa.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtIdOrdendeventa.Text = row.Cells["IdOrdendeventa"].Value.ToString();
                cbIdloteproducto.Text = row.Cells["Idloteproducto"].Value.ToString();
                cbCliente.Text = row.Cells["IdCliente"].Value.ToString();
                cbDescuento.Text = row.Cells["IdDescuento"].Value.ToString();
                cbIdFormapago.Text = row.Cells["IdFormapago"].Value.ToString();
                cbEstadoventa.Checked = Convert.ToBoolean(row.Cells["Estadoventa"].Value);
                dtFechaventa.Value = Convert.ToDateTime(row.Cells["Fechaventa"].Value);
            }
        }
        private void LlenarCliente()
        {
            List<entCliente> listaproveedor = logCliente.Instancia.Listarcliente();
            cbCliente.DataSource = listaproveedor;
            cbCliente.DisplayMember = "IdCliente"; // El nombre del animal para mostrar en el ComboBox
            cbCliente.ValueMember = "IdCliente"; // El valor real que representa al animal (su ID)
        }
        private void LlenarDescuento()
        {
            List<entDescuento> listaproveedor = logDescuento.Instancia.ListarDescuento();
            cbDescuento.DataSource = listaproveedor;
            cbDescuento.DisplayMember = "IdDescuento"; // El nombre del animal para mostrar en el ComboBox
            cbDescuento.ValueMember = "IdDescuento"; // El valor real que representa al animal (su ID)
        }
        private void LlenarFormapago()
        {
            List<entFormaPago> listaproveedor = logFormaPago.Instancia.ListarMetodoPago();
            cbIdFormapago.DataSource = listaproveedor;
            cbIdFormapago.DisplayMember = "IdFormapago"; // El nombre del animal para mostrar en el ComboBox
            cbIdFormapago.ValueMember = "IdFormapago"; // El valor real que representa al animal (su ID)
        }
        public void ListarOrdenVenta()
        {
            dgvOrdenventa.DataSource = logOrdenVenta.Instancia.ListarOrdenVenta();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenVenta c = new entOrdenVenta();
                c.Idloteproducto = Convert.ToInt32(cbIdloteproducto.Text.Trim());
                c.IdCliente = Convert.ToInt32(cbCliente.SelectedValue); // Usando SelectedValue
                c.IdDescuento = Convert.ToInt32(cbDescuento.SelectedValue); // Usando SelectedValue
                c.IdFormapago = Convert.ToInt32(cbIdFormapago.SelectedValue); // Usando SelectedValue
                c.Estadoventa = cbEstadoventa.Checked; // Correcto uso de Checked para CheckBox
                c.Fechaventa = Convert.ToDateTime(dtFechaventa.Text.Trim());

                logOrdenVenta.Instancia.InsertarOrdenVenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarOrdenVenta();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenVenta c = new entOrdenVenta();
                c.IdOrdendeventa = int.Parse(txtIdOrdendeventa.Text.Trim());
                logOrdenVenta.Instancia.DeshabilitarOrdenVenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOrdenVenta();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdOrdendeventa = int.Parse(txtNumDoc1.Text.Trim()); // Asumiendo que txtIdBusqueda es tu TextBox para la entrada del ID
                entOrdenVenta resultado = logOrdenVenta.Instancia.BuscarOrdenVenta(IdOrdendeventa);

                if (resultado != null)
                {
                    // Si se encuentra la orden de venta, puedes mostrar sus detalles
                    // Por ejemplo, podrías cargar los detalles en los controles del formulario o en un DataGridView
                    txtIdOrdendeventa.Text = resultado.IdOrdendeventa.ToString();
                    // ... establecer el resto de los controles ...
                }
                else
                {
                    MessageBox.Show("Orden de venta no encontrada.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
