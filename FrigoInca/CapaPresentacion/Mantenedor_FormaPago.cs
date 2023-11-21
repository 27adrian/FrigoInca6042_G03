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
    public partial class Mantenedor_FormaPago : Form
    {
        public Mantenedor_FormaPago()
        {
            InitializeComponent();
            ListarMetodoPago();

        }
        public void ListarMetodoPago()
        {
            dgvFormaPago.DataSource = logFormaPago.Instancia.ListarMetodoPago();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entFormaPago c = new entFormaPago();
                c.NombreFp = txt_NombreFP.Text.Trim();

                logFormaPago.Instancia.InsertarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarMetodoPago();
        }
    }
}
