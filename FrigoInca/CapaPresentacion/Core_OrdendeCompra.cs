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
    public partial class Core_OrdendeCompra : Form
    {
        public Core_OrdendeCompra()
        {
            InitializeComponent();
            ListarOrdencompra();
            LlenarProveedor();
            LlenarFormapago();
        }
        public void ListarOrdencompra()
        {
            dgv_Compras.DataSource = logOrdencompra.Instancia.ListarOrdencompra();
        }
        private void dgv_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LlenarProveedor()
        {
            List<entProveedor> listaproveedor = logProveedor.Instancia.Listarproveedor();
            cbIdproveedor.DataSource = listaproveedor;
            cbIdproveedor.DisplayMember = "IdProveedor"; // El nombre del animal para mostrar en el ComboBox
            cbIdproveedor.ValueMember = "IdProveedor"; // El valor real que representa al animal (su ID)
        }
        private void LlenarFormapago()
        {
            List<entFormaPago> listaformapago = logFormaPago.Instancia.ListarMetodoPago();
            cbMetodoPago.DataSource = listaformapago;
            cbMetodoPago.DisplayMember = "IdFormapago"; // El nombre del animal para mostrar en el ComboBox
            cbMetodoPago.ValueMember = "IdFormapago"; // El valor real que representa al animal (su ID)
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdencompra c = new entOrdencompra();
                c.IdProveedor = Convert.ToInt32(cbIdproveedor.Text.Trim());
                c.IdFormapago = Convert.ToInt32(cbMetodoPago.Text.Trim());
                c.Cantidad = Convert.ToInt32(txt_Cantidad.Text.Trim());
                c.Fechacompra = Convert.ToDateTime(dtFechacompra.Text.Trim());
                logOrdencompra.Instancia.InsertarOrdencompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarOrdencompra();
        }
    }
}
