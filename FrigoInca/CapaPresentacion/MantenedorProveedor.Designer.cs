﻿namespace CapaPresentacion
{
    partial class MantenedorProveedor
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
            this.gb_Proveedor = new System.Windows.Forms.GroupBox();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cbxTipoProveedor = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Documento_identidad = new System.Windows.Forms.TextBox();
            this.lblTipoProveedor = new System.Windows.Forms.Label();
            this.txt_Telefono_contacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_N_proveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 347);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 265);
            this.dataGridView1.TabIndex = 14;
            // 
            // gb_Proveedor
            // 
            this.gb_Proveedor.Controls.Add(this.cbxTipoDoc);
            this.gb_Proveedor.Controls.Add(this.lblTipoDoc);
            this.gb_Proveedor.Controls.Add(this.cbxTipoProveedor);
            this.gb_Proveedor.Controls.Add(this.btn_Eliminar);
            this.gb_Proveedor.Controls.Add(this.btn_Modificar);
            this.gb_Proveedor.Controls.Add(this.btn_Agregar);
            this.gb_Proveedor.Controls.Add(this.label4);
            this.gb_Proveedor.Controls.Add(this.txt_Correo);
            this.gb_Proveedor.Controls.Add(this.txt_Documento_identidad);
            this.gb_Proveedor.Controls.Add(this.lblTipoProveedor);
            this.gb_Proveedor.Controls.Add(this.txt_Telefono_contacto);
            this.gb_Proveedor.Controls.Add(this.label3);
            this.gb_Proveedor.Controls.Add(this.txt_N_proveedor);
            this.gb_Proveedor.Controls.Add(this.label5);
            this.gb_Proveedor.Controls.Add(this.label6);
            this.gb_Proveedor.Location = new System.Drawing.Point(28, 33);
            this.gb_Proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Proveedor.Name = "gb_Proveedor";
            this.gb_Proveedor.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Proveedor.Size = new System.Drawing.Size(797, 276);
            this.gb_Proveedor.TabIndex = 13;
            this.gb_Proveedor.TabStop = false;
            this.gb_Proveedor.Text = "Informacion Proveedor";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cbxTipoDoc.Location = new System.Drawing.Point(239, 119);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(264, 24);
            this.cbxTipoDoc.TabIndex = 17;
            this.cbxTipoDoc.Text = "--Seleccionar tipo de documento--";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(25, 122);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(127, 16);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cbxTipoProveedor
            // 
            this.cbxTipoProveedor.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cbxTipoProveedor.Location = new System.Drawing.Point(239, 34);
            this.cbxTipoProveedor.Name = "cbxTipoProveedor";
            this.cbxTipoProveedor.Size = new System.Drawing.Size(264, 24);
            this.cbxTipoProveedor.TabIndex = 15;
            this.cbxTipoProveedor.Text = "--Seleccionar tipo de proveedor--";
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
            this.label4.Location = new System.Drawing.Point(25, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de documento:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(239, 193);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(264, 22);
            this.txt_Correo.TabIndex = 10;
            // 
            // txt_Documento_identidad
            // 
            this.txt_Documento_identidad.Location = new System.Drawing.Point(239, 158);
            this.txt_Documento_identidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Documento_identidad.Name = "txt_Documento_identidad";
            this.txt_Documento_identidad.Size = new System.Drawing.Size(264, 22);
            this.txt_Documento_identidad.TabIndex = 9;
            // 
            // lblTipoProveedor
            // 
            this.lblTipoProveedor.AutoSize = true;
            this.lblTipoProveedor.Location = new System.Drawing.Point(25, 37);
            this.lblTipoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoProveedor.Name = "lblTipoProveedor";
            this.lblTipoProveedor.Size = new System.Drawing.Size(124, 16);
            this.lblTipoProveedor.TabIndex = 1;
            this.lblTipoProveedor.Text = "Tipo de Proveedor:";
            // 
            // txt_Telefono_contacto
            // 
            this.txt_Telefono_contacto.Location = new System.Drawing.Point(239, 231);
            this.txt_Telefono_contacto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono_contacto.Name = "txt_Telefono_contacto";
            this.txt_Telefono_contacto.Size = new System.Drawing.Size(264, 22);
            this.txt_Telefono_contacto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // txt_N_proveedor
            // 
            this.txt_N_proveedor.Location = new System.Drawing.Point(239, 75);
            this.txt_N_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_N_proveedor.Name = "txt_N_proveedor";
            this.txt_N_proveedor.Size = new System.Drawing.Size(264, 22);
            this.txt_N_proveedor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Proveedor);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Proveedor.ResumeLayout(false);
            this.gb_Proveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Proveedor;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cbxTipoProveedor;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Documento_identidad;
        private System.Windows.Forms.Label lblTipoProveedor;
        private System.Windows.Forms.TextBox txt_Telefono_contacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_N_proveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}