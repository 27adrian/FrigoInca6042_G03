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
    public partial class Mantenedor_Corte : Form
    {
        public Mantenedor_Corte()
        {
            InitializeComponent();
            ListarCorte();
        }

        private void Mantenedor_Corte_Load(object sender, EventArgs e)
        {

        }
        public void ListarCorte()
        {
            dgvCorte.DataSource = logCorte.Instancia.ListarCorte();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
