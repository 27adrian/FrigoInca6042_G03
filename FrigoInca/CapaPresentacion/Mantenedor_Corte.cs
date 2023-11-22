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
    public partial class Mantenedor_Corte : Form
    {
        public Mantenedor_Corte()
        {
            InitializeComponent();
            ListarCorte();
            txtNombrecorte.KeyPress += txtNombrecorte_KeyPress;
            txtPreciocorte.KeyPress += txtPreciocorte_KeyPress;
            dgvCorte.CellClick += dgvCorte_CellClick;

        }
        private void dgvCorte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCorte.Enabled = false;
            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCorte.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtIdCorte.Text = row.Cells["IdCorte"].Value.ToString();
                txtNombrecorte.Text = row.Cells["Nombrecorte"].Value.ToString();
                txtPreciocorte.Text = row.Cells["Preciocorte"].Value.ToString();
            }
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
        private void txtPreciocorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtNombrecorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entCorte c = new entCorte();
                c.NombreCorte = txtNombrecorte.Text.Trim();
                c.Preciocorte = Decimal.Parse(txtPreciocorte.Text.Trim());

                logCorte.Instancia.InsertarCorte(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarCorte();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entCorte c = new entCorte();
                c.IdCorte = int.Parse(txtIdCorte.Text);
                c.NombreCorte = txtNombrecorte.Text; // No es necesario .ToString() ya que es un string
                c.Preciocorte = Decimal.Parse(txtPreciocorte.Text.Trim()); // Cambiado a Decimal.Parse

                logCorte.Instancia.EditarCorte(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarCorte();

        }
    }
}
