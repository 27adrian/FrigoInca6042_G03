﻿namespace FrigoInca
{
    partial class Core_OrdendeCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgv_Compras = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechacompra = new System.Windows.Forms.DateTimePicker();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cbIdproveedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumDoc1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(24, 180);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 28);
            this.btn_Agregar.TabIndex = 37;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgv_Compras
            // 
            this.dgv_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Compras.Location = new System.Drawing.Point(16, 228);
            this.dgv_Compras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Compras.Name = "dgv_Compras";
            this.dgv_Compras.RowHeadersWidth = 51;
            this.dgv_Compras.Size = new System.Drawing.Size(781, 284);
            this.dgv_Compras.TabIndex = 36;
            this.dgv_Compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Compras_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Forma de Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Fecha Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "IdProveedor:";
            // 
            // dtFechacompra
            // 
            this.dtFechacompra.Location = new System.Drawing.Point(209, 139);
            this.dtFechacompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechacompra.Name = "dtFechacompra";
            this.dtFechacompra.Size = new System.Drawing.Size(265, 22);
            this.dtFechacompra.TabIndex = 39;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(208, 108);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(265, 22);
            this.txt_Cantidad.TabIndex = 62;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(208, 75);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(265, 24);
            this.cbMetodoPago.TabIndex = 63;
            // 
            // cbIdproveedor
            // 
            this.cbIdproveedor.FormattingEnabled = true;
            this.cbIdproveedor.Location = new System.Drawing.Point(208, 46);
            this.cbIdproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdproveedor.Name = "cbIdproveedor";
            this.cbIdproveedor.Size = new System.Drawing.Size(265, 24);
            this.cbIdproveedor.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumDoc1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(531, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 178);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "IdOrdendecompra:";
            // 
            // txtNumDoc1
            // 
            this.txtNumDoc1.Location = new System.Drawing.Point(36, 63);
            this.txtNumDoc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumDoc1.MaxLength = 8;
            this.txtNumDoc1.Name = "txtNumDoc1";
            this.txtNumDoc1.Size = new System.Drawing.Size(204, 22);
            this.txtNumDoc1.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(73, 122);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 47);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Id Ordendecompra:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(208, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 67;
            // 
            // Core_OrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 537);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbIdproveedor);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.dtFechacompra);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Compras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Core_OrdendeCompra";
            this.Text = "Core_OrdendeCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_Compras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechacompra;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.ComboBox cbIdproveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumDoc1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}