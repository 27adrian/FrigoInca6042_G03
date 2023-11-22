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
    public partial class Mantenedor_RequerimientoCompra : Form
    {
        public Mantenedor_RequerimientoCompra()
        {
            InitializeComponent();
            LlenarComboBoxAnimales();
            ListarRequerimientosCompra();
        }

        private void LlenarComboBoxAnimales()
        {
            List<entAnimal> listaAnimales = logAnimal.Instancia.ListarAnimal();
            cbIdAnimal.DataSource = listaAnimales;
            cbIdAnimal.DisplayMember = "IdAnimal"; // El nombre del animal para mostrar en el ComboBox
            cbIdAnimal.ValueMember = "IdAnimal"; // El valor real que representa al animal (su ID)
        }
        public void ListarRequerimientosCompra()
        {
            dgvRequerimientocompra.DataSource = logRequerimientcompra.Instancia.ListarRequerimientosCompra();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientocompra c = new entRequerimientocompra();
                c.IdAnimal = Convert.ToInt32(cbIdAnimal.Text.Trim());
                c.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

                logRequerimientcompra.Instancia.InsertarRequerimientoCompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarRequerimientosCompra();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
