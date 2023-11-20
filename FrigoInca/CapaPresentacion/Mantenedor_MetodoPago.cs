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
    public partial class Mantenedor_MetodoPago : Form
    {
        public Mantenedor_MetodoPago()
        {
            InitializeComponent();
            ListarMetodoPago();

        }
        public void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago c = new entMetodoPago();
                c.Tipo = txt_Metodo.Text.Trim();
                c.Descripcion = txt_Descripcion.Text.Trim();

                logMetodoPago.Instancia.InsertarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarMetodoPago();
        }
    }
}
