﻿using CapaEntidad;
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
    public partial class Mantenedor_Ubigeo : Form
    {
        public Mantenedor_Ubigeo()
        {
            InitializeComponent();
            ListarUbigeo();
            dgvUbigeo.CellClick += dgvUbigeo_CellClick;
            txtDepartamento.KeyPress += txtDepartamento_KeyPress;

        }
        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y teclas de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Mantenedor_Ubigeo_Load(object sender, EventArgs e)
        {

        }
        private void dgvUbigeo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUbigeo.Enabled = false;

            // Verifica si el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUbigeo.Rows[e.RowIndex];

                // Suponiendo que tienes las columnas 'IdUbigeo', 'Departamento', 'Provincia' y 'Distrito'
                txtIdUbigeo.Text = row.Cells["IdUbigeo"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                txtProvincia.Text = row.Cells["Provincia"].Value.ToString();
                txtDistrito.Text = row.Cells["Distrito"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entUbigeo c = new entUbigeo();
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                c.Departamento = txtDepartamento.Text.Trim();
                c.Provincia = txtProvincia.Text.Trim();
                c.Distrito = txtDistrito.Text.Trim();

                logUbigeo.Instancia.InsertarUbigeo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            ListarUbigeo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entUbigeo c = new entUbigeo();
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());
                c.Departamento = txtDepartamento.Text.Trim();
                c.Provincia = txtProvincia.Text.Trim();
                c.Distrito = txtDistrito.Text.Trim();
                logUbigeo.Instancia.EditarUbigeo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarUbigeo();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva instancia de entUbigeo
                entUbigeo c = new entUbigeo();
                c.IdUbigeo = int.Parse(txtIdUbigeo.Text.Trim());

                // Llamar al método Deshabilitar en logUbigeo
                logUbigeo.Instancia.Deshabilitar(c);

                MessageBox.Show("Ubigeo deshabilitado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Actualizar la lista para reflejar los cambios
            ListarUbigeo();
        }
        public void ListarUbigeo()
        {
            dgvUbigeo.DataSource = logUbigeo.Instancia.ListarUbigeo();
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
