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
    public partial class Mantenedor_RequerimientoCompra : Form
    {
        public Mantenedor_RequerimientoCompra()
        {
            InitializeComponent();
            LlenarComboBoxAnimales();
            ListarRequerimientosCompra();
            dgvRequerimientocompra.CellClick += dgvRequerimiento_CellClick;
            cbIdAnimal.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void dgvRequerimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbIdAnimal.Enabled = false;
            txtIdRequerimientocompra.Enabled = false;

            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRequerimientocompra.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtIdRequerimientocompra.Text = row.Cells["IdRequerimientocompra"].Value.ToString();
                cbIdAnimal.Text = row.Cells["IdAnimal"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
            }
        }
        private void LlenarComboBoxAnimales()
        {
            List<entAnimal> listaAnimales = logAnimal.Instancia.ListarAnimal();
            cbIdAnimal.DataSource = listaAnimales;
            cbIdAnimal.DisplayMember = "IdAnimal"; // El nombre del animal para mostrar en el ComboBox
            cbIdAnimal.ValueMember = "IdAnimal"; // El valor real que representa al animal (su ID)
        }
        public void ListarRequerimientosCompra()
        {
            dgvRequerimientocompra.DataSource = logRequerimientcompra.Instancia.ListarRequerimientosCompra();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientocompra c = new entRequerimientocompra();
                c.IdAnimal = Convert.ToInt32(cbIdAnimal.Text.Trim());
                c.Cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

                logRequerimientcompra.Instancia.InsertarRequerimientoCompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarRequerimientosCompra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entRequerimientocompra c = new entRequerimientocompra();

                // Obtener el IdRequerimientocompra del control de texto
                c.IdRequerimientocompra = int.Parse(txtIdRequerimientocompra.Text); // Usar .Text para obtener el valor
                c.IdAnimal = int.Parse(cbIdAnimal.SelectedValue.ToString()); // Asegúrate de que este valor es numérico
                c.Cantidad = int.Parse(txtCantidad.Text.Trim());

                logRequerimientcompra.Instancia.EditarRequerimientoCompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarRequerimientosCompra();
        }


        private void cbIdAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
