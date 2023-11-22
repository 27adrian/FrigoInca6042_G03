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
    public partial class Mantenedor_Descuento : Form
    {
        public Mantenedor_Descuento()
        {
            InitializeComponent();
            ListarDescuento();
            txtProcentaje.KeyPress += txtProcentaje_KeyPress;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entDescuento c = new entDescuento();
                c.Porcentaje = Decimal.Parse(txtProcentaje.Text.Trim());

                logDescuento.Instancia.InsertarDescuento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarDescuento();
        }
        public void ListarDescuento()
        {
            dgvDescuento.DataSource = logDescuento.Instancia.ListarDescuento();
        }
        private void txtProcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtProcentaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
