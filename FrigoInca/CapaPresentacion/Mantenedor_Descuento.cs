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
    }
}
