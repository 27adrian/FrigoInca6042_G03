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
    public partial class Form_NombreProducto : Form
    {
        public Form_NombreProducto()
        {
            InitializeComponent();
            ListaNombreproducto();
        }
        public void ListaNombreproducto()
        {
            dgvNombreproducto.DataSource = logNombreproducto.Instancia.ListarNombreproducto();
        }
        private void dgvNombreproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
