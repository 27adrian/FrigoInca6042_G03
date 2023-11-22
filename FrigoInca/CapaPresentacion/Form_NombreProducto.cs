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
    public partial class Form_NombreProducto : Form
    {
        public Form_NombreProducto()
        {
            InitializeComponent();
            ListaNombreproducto();
            dgvNombreproducto.CellClick += dgvNombreproducto_CellClick;
        }
        private void dgvNombreproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNombreproducto.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtNombreproducto.Text = row.Cells["Nombreproducto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }
        public void ListaNombreproducto()
        {
            dgvNombreproducto.DataSource = logNombreproducto.Instancia.ListarNombreproducto();
        }
        private void dgvNombreproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entNombreproducto c = new entNombreproducto();
                c.Nombreproducto = txtNombreproducto.Text.Trim();
                c.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());

                logNombreproducto.Instancia.InsertarNombreproducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListaNombreproducto();
        }
    }
}
