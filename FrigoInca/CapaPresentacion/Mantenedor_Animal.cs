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
    public partial class Mantenedor_Animal : Form
    {
        public Mantenedor_Animal()
        {
            InitializeComponent();
            ListarAnimal();
            dgvAnimal.CellClick += dgvAnimal_CellClick;

        }
        private void dgvAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAnimal.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtAnimal.Text = row.Cells["Nombreanimal"].Value.ToString();
            }
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
                c.Nombreanimal = txtAnimal.Text.Trim();

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
