﻿using CapaLogicaNegocio;
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
    public partial class Core_OrdendeCompra : Form
    {
        public Core_OrdendeCompra()
        {
            InitializeComponent();
            ListarProveedor();
            txtNombre.Enabled = false;
            txt_NumeroDocumento.Enabled = false;
            txtIdUbigeo.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreoElectronico.Enabled = false;   
            dgvProveedor.CellClick += new DataGridViewCellEventHandler(dgvProveedor_CellClick);
        }
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is not the header and not -1 (no selection)
            if (e.RowIndex >= 0)
            {
                // Assuming the ID is in the first column, index 0
                string nombre = dgvProveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                string numerodocumento = dgvProveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                string idubigeo = dgvProveedor.Rows[e.RowIndex].Cells[9].Value.ToString();
                string telefono = dgvProveedor.Rows[e.RowIndex].Cells[6].Value.ToString();
                string correo = dgvProveedor.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Set the ID to your TextBox
                txtNombre.Text = nombre;
                txt_NumeroDocumento.Text = numerodocumento;
                txtIdUbigeo.Text = idubigeo;
                txtTelefono.Text = telefono;
                txtCorreoElectronico.Text = correo;
            }
        }
        public void ListarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.Listarproveedor();
        }
        private void dgv_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
