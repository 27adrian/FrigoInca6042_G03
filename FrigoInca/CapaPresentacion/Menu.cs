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

        private void button1_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.ShowDialog();
            this.Show();
        }

        private void btnMProveedor_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mprov = new MantenedorProveedor();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrarLotes rLotes = new RegistrarLotes();
            this.Hide();
            rLotes.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenedorEnvios mEnv = new MantenedorEnvios();
            this.Hide();
            mEnv.ShowDialog();
            this.Show();
        }

        private void btnROrdenVent_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteArriba_Click(object sender, EventArgs e)
        {
            MantenedorCliente mc = new MantenedorCliente();
            this.Hide();
            mc.ShowDialog();
            this.Show();
        }

        private void btnProveeArriba_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mprov = new MantenedorProveedor();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCompras mprov = new FormCompras();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormReportes mprov = new FormReportes();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void btnRPedidoCarne_Click(object sender, EventArgs e)
        {
            FormPedidoDeCarne mprov = new FormPedidoDeCarne();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }
    }
}
