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
    public partial class Form_Lote : Form
    {
        public Form_Lote()
        {
            InitializeComponent();
        }
        
        public void nombresColumnasMP()
        {
            dgvMateriaPrima.Columns[0].HeaderText = "ID";
            dgvMateriaPrima.Columns[1].HeaderText = "Animal";
            dgvMateriaPrima.Columns[2].HeaderText = "Peso";
            dgvMateriaPrima.Columns[3].HeaderText = "Calidad";
            dgvMateriaPrima.Columns[4].Visible = false;
        }

        public void nombresColumnasLP()
        {
            dgvLoteProducto.Columns[0].HeaderText = "ID";
            dgvLoteProducto.Columns[1].HeaderText = "Materia Prima";
            dgvLoteProducto.Columns[2].HeaderText = "Corte";
            dgvLoteProducto.Columns[3].HeaderText = "Nombre Producto";
            dgvLoteProducto.Columns[4].HeaderText = "Peso";
            dgvLoteProducto.Columns[5].HeaderText = "Cantidad";
            dgvLoteProducto.Columns[6].HeaderText = "Fecha Registro";
            dgvLoteProducto.Columns[6].Visible = false;
        }

        private void rBtnCorte_CheckedChanged(object sender, EventArgs e)
        {
            ListarComboCorte();
            lblProducto.Text = "Corte:";
            dgvLoteProducto.Enabled = false;
            lblCantidad.Enabled = false;
            txtCantidadCarne.Enabled = false;
            dgvMateriaPrima.Enabled = true;
            lblPeso.Enabled = true;
            txtPesoCarne.Enabled = true;
        }

        private void rBtnDerivado_CheckedChanged(object sender, EventArgs e)
        {
            ListarComboDerivado();
            lblProducto.Text = "Derivado:";
            dgvMateriaPrima.Enabled = false;
            lblPeso.Enabled = false;
            txtPesoCarne.Enabled = false;
            dgvLoteProducto.Enabled = true;
            lblCantidad.Enabled = true;
            txtCantidadCarne.Enabled = true;
        }
        
        private void dgvMateriaPrima_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMateriaPrima.Rows[e.RowIndex];

                tbxIDmp.Text = row.Cells[0].Value?.ToString();
                tBxTipoCarne.Text = row.Cells[1].Value?.ToString();
            }
        }

        public void ListarComboCorte()
        {
            cBxProducto.DataSource = logLoteProducto.Instancia.ListarComboCarner();

            cBxProducto.ValueMember = "IdCorte";
            cBxProducto.DisplayMember = "NombreCorte";
        }

        public void ListarComboDerivado()
        {
            cBxProducto.DataSource = logLoteProducto.Instancia.ListarComboCarnerDerivado();

            cBxProducto.ValueMember = "IdNombreproducto";
            cBxProducto.DisplayMember = "Nombreproducto";
        }

        public void ListarLoteProducto()
        {
            dgvLoteProducto.DataSource = logLoteProducto.Instancia.ListarLoteProducto();
            nombresColumnasLP();
        }
        public void ListarMateriaPrima()
        {
            dgvMateriaPrima.DataSource = logIngresaMateriaPrima.Instancia.ListarMateriaPrima();
            nombresColumnasMP();
        }

        private void dgvLoteProducto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoteProducto.Rows[e.RowIndex];

                tbxIDmp.Text = row.Cells[1].Value?.ToString();
                tBxTipoCarne.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void Form_Lote_Load(object sender, EventArgs e)
        {
            List<entLoteProducto> listLoteProducto = new List<entLoteProducto>();
            dgvLoteProducto.DataSource = listLoteProducto;
            ListarLoteProducto();
            ListarMateriaPrima();
            ListarComboCorte();
            lblPeso.Enabled = false;
            txtPesoCarne.Enabled = false;
            lblCantidad.Enabled = false;
            txtCantidadCarne.Enabled = false;
            dgvMateriaPrima.Enabled = false;
            dgvLoteProducto.Enabled = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (rBtnCorte.Checked)
            {
                bool Respuesta = logLoteProducto.Instancia.RestarPeso(Convert.ToInt32(tbxIDmp.Text), Convert.ToDecimal(txtPesoCarne.Text));

                entLoteProducto c = new entLoteProducto();
                c.IdIngresomateriaprima = Convert.ToInt32(tbxIDmp.Text);
                c.IdCorte = Convert.ToInt32(cBxProducto.SelectedValue.ToString());
                c.IdNombreproducto = Convert.ToInt32(cBxProducto.SelectedValue.ToString());
                c.Peso = Convert.ToInt32(txtPesoCarne.Text);
                c.Cantidad = 0;
                c.Fechalote = dateTimePicker1.Value;
                if (logLoteProducto.Instancia.InsertarLoteProducto(c))
                {
                    MessageBox.Show("Ingreso correcto de datos.", "CONFIRMACION INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ListarMateriaPrima();
                ListarLoteProducto();
            }
            if (rBtnDerivado.Checked)
            {
                DataGridViewRow filaActual = dgvLoteProducto.Rows[dgvLoteProducto.SelectedCells[0].RowIndex];
                int loteActual = Convert.ToInt32(filaActual.Cells[0].Value);

                if (logLoteProducto.Instancia.RestarCantidad(loteActual, Convert.ToInt32((txtCantidadCarne.Text))))
                {
                    entLoteProducto c = new entLoteProducto();
                    c.IdIngresomateriaprima = Convert.ToInt32(tbxIDmp.Text);
                    c.IdCorte = Convert.ToInt32(tBxTipoCarne.Text);
                    c.IdNombreproducto = Convert.ToInt32(cBxProducto.SelectedValue.ToString());
                    c.Peso = Convert.ToInt32(txtCantidadCarne.Text);
                    c.Cantidad = Convert.ToInt32(txtCantidadCarne.Text);
                    c.Fechalote = dateTimePicker1.Value;
                    if (logLoteProducto.Instancia.InsertarLoteProductoRecursivo(c))
                    {
                        MessageBox.Show("Ingreso correcto de datos.", "CONFIRMACION INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarLoteProducto();
                    }
                }
            } 
        }

        private void dgvLoteProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    DataGridViewRow filaActual = dgvLoteProducto.Rows[dgvLoteProducto.SelectedCells[0].RowIndex];

            //    switch (e.ColumnIndex)
            //    {
            //        case 1:
            //            using(frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(1, Convert.ToInt32(filaActual.Cells[1].Value)))
            //            {
            //                ofrmMostrarNombre.ShowDialog();
            //            }
            //            break;
            //        case 2:
            //            using (frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(2, Convert.ToInt32(filaActual.Cells[2].Value)))
            //            {
            //                ofrmMostrarNombre.ShowDialog();
            //            }
            //            break;
            //        case 3:
            //            using (frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(3, Convert.ToInt32(filaActual.Cells[3].Value)))
            //            {
            //                ofrmMostrarNombre.ShowDialog();
            //            }
            //            break;

            //    }
            //}
        }

        private void dgvLoteProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvLoteProducto.Rows[dgvLoteProducto.SelectedCells[0].RowIndex];

                switch (e.ColumnIndex)
                {
                    case 1:
                        using (frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(1, Convert.ToInt32(filaActual.Cells[1].Value)))
                        {
                            ofrmMostrarNombre.ShowDialog();
                        }
                        break;
                    case 2:
                        using (frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(2, Convert.ToInt32(filaActual.Cells[2].Value)))
                        {
                            ofrmMostrarNombre.ShowDialog();
                        }
                        break;
                    case 3:
                        using (frmMostrarNombre ofrmMostrarNombre = new frmMostrarNombre(3, Convert.ToInt32(filaActual.Cells[3].Value)))
                        {
                            ofrmMostrarNombre.ShowDialog();
                        }
                        break;

                }
            }
        }
    }
}
