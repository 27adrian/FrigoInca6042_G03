﻿using FrigoInca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMCliente_Click(object sender, EventArgs e)
        {
            Mantenedor_Cliente mc = new Mantenedor_Cliente();
            this.Hide();
            mc.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMDesct_Click(object sender, EventArgs e)
        {
            Mantenedor_Descuento mdsc = new Mantenedor_Descuento();
            this.Hide();
            mdsc.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.ShowDialog();
            this.Show();
        }

        private void btnMProveedor_Click(object sender, EventArgs e)
        {
            Mantenedor_Proveedor mprov = new Mantenedor_Proveedor();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mantenedor_Animal rLotes = new Mantenedor_Animal();
            this.Hide();
            rLotes.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnROrdenVent_Click(object sender, EventArgs e)
        {
            Core_OrdendeVenta mEnv = new Core_OrdendeVenta();
            this.Hide();
            mEnv.ShowDialog();
            this.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteArriba_Click(object sender, EventArgs e)
        {
            Mantenedor_Cliente mc = new Mantenedor_Cliente();
            this.Hide();
            mc.ShowDialog();
            this.Show();
        }

        private void btnProveeArriba_Click(object sender, EventArgs e)
        {
            Mantenedor_Proveedor mprov = new Mantenedor_Proveedor();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Core_OrdendeCompra mprov = new Core_OrdendeCompra();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnRPedidoCarne_Click(object sender, EventArgs e)
        {
            Core_OrdendeCompra mprov = new Core_OrdendeCompra();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Mantenedor_Cliente mprov = new Mantenedor_Cliente();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mantenedor_Proveedor mprov = new Mantenedor_Proveedor();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Mantenedor_RequerimientoCompra mprov = new Mantenedor_RequerimientoCompra();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void btnRIngresoMP_Click(object sender, EventArgs e)
        {
            Core_IngresaMateriaPrima mprov = new Core_IngresaMateriaPrima();
            this.Hide();
            mprov.ShowDialog();
            this.Show();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mantenedor_Ubigeo fcp = new Mantenedor_Ubigeo();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mantenedor_FormaPago fcp = new Mantenedor_FormaPago();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mantenedor_Descuento fcp = new Mantenedor_Descuento();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_NombreProducto fcp = new Form_NombreProducto();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mantenedor_Corte fcp = new Mantenedor_Corte();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form_Lote fcp = new Form_Lote();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    FormPedidoDeCarne mprov = new FormPedidoDeCarne();
        //    this.Hide();
        //    mprov.ShowDialog();
        //    this.Show();
        //}
    }
}
