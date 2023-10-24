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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMCliente_Click(object sender, EventArgs e)
        {
            MantenedorCliente mc = new MantenedorCliente();
            this.Hide();
            mc.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMDesct_Click(object sender, EventArgs e)
        {
            MantenedorDescuento mdsc = new MantenedorDescuento();
            this.Hide();
            mdsc.ShowDialog();
            this.Show();
        }
    }
}
