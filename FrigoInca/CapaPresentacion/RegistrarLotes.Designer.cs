﻿namespace FrigoInca
{
    partial class RegistrarLotes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_Lote = new System.Windows.Forms.GroupBox();
            this.cbxCalidad = new System.Windows.Forms.ComboBox();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.cbxTipoCarne = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KgCarne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Lote.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 351);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 265);
            this.dataGridView1.TabIndex = 14;
            // 
            // gb_Lote
            // 
            this.gb_Lote.Controls.Add(this.comboBox1);
            this.gb_Lote.Controls.Add(this.label5);
            this.gb_Lote.Controls.Add(this.label2);
            this.gb_Lote.Controls.Add(this.textBox1);
            this.gb_Lote.Controls.Add(this.label1);
            this.gb_Lote.Controls.Add(this.cbxCalidad);
            this.gb_Lote.Controls.Add(this.lblCalidad);
            this.gb_Lote.Controls.Add(this.cbxTipoCarne);
            this.gb_Lote.Controls.Add(this.btn_Eliminar);
            this.gb_Lote.Controls.Add(this.btn_Modificar);
            this.gb_Lote.Controls.Add(this.btn_Agregar);
            this.gb_Lote.Controls.Add(this.label4);
            this.gb_Lote.Controls.Add(this.txt_Fecha);
            this.gb_Lote.Controls.Add(this.lblTipoCliente);
            this.gb_Lote.Controls.Add(this.label3);
            this.gb_Lote.Controls.Add(this.txt_KgCarne);
            this.gb_Lote.Location = new System.Drawing.Point(39, 37);
            this.gb_Lote.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Lote.Name = "gb_Lote";
            this.gb_Lote.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Lote.Size = new System.Drawing.Size(797, 276);
            this.gb_Lote.TabIndex = 13;
            this.gb_Lote.TabStop = false;
            this.gb_Lote.Text = "Informacion lote";
            // 
            // cbxCalidad
            // 
            this.cbxCalidad.Items.AddRange(new object[] {
            "Tipo A",
            "Tipo B",
            "Tipo C",
            "Tipo D"});
            this.cbxCalidad.Location = new System.Drawing.Point(239, 178);
            this.cbxCalidad.Name = "cbxCalidad";
            this.cbxCalidad.Size = new System.Drawing.Size(264, 24);
            this.cbxCalidad.TabIndex = 17;
            this.cbxCalidad.Text = "--Seleccionar calidad de la carne--";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Location = new System.Drawing.Point(25, 181);
            this.lblCalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(57, 16);
            this.lblCalidad.TabIndex = 16;
            this.lblCalidad.Text = "Calidad:";
            // 
            // cbxTipoCarne
            // 
            this.cbxTipoCarne.Items.AddRange(new object[] {
            "Res",
            "Cerdo",
            "Pollo"});
            this.cbxTipoCarne.Location = new System.Drawing.Point(239, 85);
            this.cbxTipoCarne.Name = "cbxTipoCarne";
            this.cbxTipoCarne.Size = new System.Drawing.Size(264, 24);
            this.cbxTipoCarne.TabIndex = 15;
            this.cbxTipoCarne.Text = "--Seleccionar tipo de carne--";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(600, 196);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(167, 60);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(600, 119);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(167, 54);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(600, 37);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(167, 60);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(239, 227);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(264, 22);
            this.txt_Fecha.TabIndex = 9;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(25, 88);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(94, 16);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo de carne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso:";
            // 
            // txt_KgCarne
            // 
            this.txt_KgCarne.Location = new System.Drawing.Point(266, 135);
            this.txt_KgCarne.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KgCarne.Name = "txt_KgCarne";
            this.txt_KgCarne.Size = new System.Drawing.Size(99, 22);
            this.txt_KgCarne.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gr";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 22);
            this.textBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Prov 1",
            "Prov 2",
            "Prov 3",
            "Prov N"});
            this.comboBox1.Location = new System.Drawing.Point(239, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "--Seleccionar proveedor--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Proveedor:";
            // 
            // RegistrarLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Lote);
            this.Name = "RegistrarLotes";
            this.Text = "RegistrarLotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Lote.ResumeLayout(false);
            this.gb_Lote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Lote;
        private System.Windows.Forms.ComboBox cbxCalidad;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.ComboBox cbxTipoCarne;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KgCarne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}