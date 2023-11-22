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
    public partial class Core_IngresaMateriaPrima : Form
    {
        public Core_IngresaMateriaPrima()
        {
            InitializeComponent();
            ListarIngresamateriaprima();
            ListarOrdencompra();
        }
        private void ListarOrdencompra()
        {
            List<entOrdencompra> listaOrdencompra = logOrdencompra.Instancia.ListarOrdencompra();
            cbIdOrdencompra.DataSource = listaOrdencompra;
            cbIdOrdencompra.DisplayMember = "IdOrdencompra"; // El nombre del animal para mostrar en el ComboBox
            cbIdOrdencompra.ValueMember = "IdOrdencompra"; // El valor real que representa al animal (su ID)
        }
        public void ListarIngresamateriaprima()
        {
            dgvMP.DataSource = logIngresaMateriaPrima.Instancia.ListarMateriaPrima();
        }
        private void Core_IngresaMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entIngresaMateriaPrima c = new entIngresaMateriaPrima();
                c.IdOrdencompra = Convert.ToInt32(cbIdOrdencompra.Text.Trim());
                c.Peso = Convert.ToInt32(txtPeso.Text.Trim());
                c.Calidad = cbCalidad.Text.Trim();
                c.Fecha = Convert.ToDateTime(dtFecha.Text.Trim());

                logIngresaMateriaPrima.Instancia.InsertarMateriaprima(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarIngresamateriaprima();
        }
    }
}
