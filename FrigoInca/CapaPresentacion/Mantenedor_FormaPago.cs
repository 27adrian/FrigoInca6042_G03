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
    public partial class Mantenedor_FormaPago : Form
    {
        public Mantenedor_FormaPago()
        {
            InitializeComponent();
            ListarMetodoPago();
            dgvFormaPago.CellClick += dgvFormaPago_CellClick;

        }
        private void dgvFormaPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFormaPago.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txt_NombreFP.Text = row.Cells["NombreFp"].Value.ToString();
            }
        }
        public void ListarMetodoPago()
        {
            dgvFormaPago.DataSource = logFormaPago.Instancia.ListarMetodoPago();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entFormaPago c = new entFormaPago();
                c.NombreFp = txt_NombreFP.Text.Trim();

                logFormaPago.Instancia.InsertarMetodoPago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarMetodoPago();
        }
    }
}
