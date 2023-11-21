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
    public partial class Mantenedor_OrigenMP : Form
    {
        public Mantenedor_OrigenMP()
        {
            InitializeComponent();
            ListarAnimal();
        }
        public void ListarAnimal()
        {
            dgvAnimal.DataSource = logAnimal.Instancia.ListarAnimal();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entAnimal c = new entAnimal();
                c.Animal = txtAnimal.Text.Trim();

                logAnimal.Instancia.InsertarAnimal(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarAnimal();
        }
    }
}
