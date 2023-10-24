namespace CapaPresentacion
{
    partial class MantenedorCliente
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
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_N_cliente = new System.Windows.Forms.TextBox();
            this.txt_Telefono_contacto = new System.Windows.Forms.TextBox();
            this.txt_Documento_identidad = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(25, 37);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(99, 16);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo de cliente:";
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
            // txt_N_cliente
            // 
            this.txt_N_cliente.Location = new System.Drawing.Point(239, 75);
            this.txt_N_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_N_cliente.Name = "txt_N_cliente";
            this.txt_N_cliente.Size = new System.Drawing.Size(264, 22);
            this.txt_N_cliente.TabIndex = 8;
            // 
            // txt_Telefono_contacto
            // 
            this.txt_Telefono_contacto.Location = new System.Drawing.Point(239, 231);
            this.txt_Telefono_contacto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono_contacto.Name = "txt_Telefono_contacto";
            this.txt_Telefono_contacto.Size = new System.Drawing.Size(264, 22);
            this.txt_Telefono_contacto.TabIndex = 9;
            // 
            // txt_Documento_identidad
            // 
            this.txt_Documento_identidad.Location = new System.Drawing.Point(239, 158);
            this.txt_Documento_identidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Documento_identidad.Name = "txt_Documento_identidad";
            this.txt_Documento_identidad.Size = new System.Drawing.Size(264, 22);
            this.txt_Documento_identidad.TabIndex = 9;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(239, 193);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(264, 22);
            this.txt_Correo.TabIndex = 10;
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.cbxTipoDoc);
            this.gb_Cliente.Controls.Add(this.lblTipoDoc);
            this.gb_Cliente.Controls.Add(this.cbxTipoCliente);
            this.gb_Cliente.Controls.Add(this.btn_Eliminar);
            this.gb_Cliente.Controls.Add(this.btn_Modificar);
            this.gb_Cliente.Controls.Add(this.btn_Agregar);
            this.gb_Cliente.Controls.Add(this.label4);
            this.gb_Cliente.Controls.Add(this.txt_Correo);
            this.gb_Cliente.Controls.Add(this.txt_Documento_identidad);
            this.gb_Cliente.Controls.Add(this.lblTipoCliente);
            this.gb_Cliente.Controls.Add(this.txt_Telefono_contacto);
            this.gb_Cliente.Controls.Add(this.label3);
            this.gb_Cliente.Controls.Add(this.txt_N_cliente);
            this.gb_Cliente.Controls.Add(this.label5);
            this.gb_Cliente.Controls.Add(this.label6);
            this.gb_Cliente.Location = new System.Drawing.Point(32, 31);
            this.gb_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Cliente.Size = new System.Drawing.Size(797, 276);
            this.gb_Cliente.TabIndex = 11;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Informacion cliente";
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
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(239, 34);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(264, 24);
            this.cbxTipoCliente.TabIndex = 15;
            this.cbxTipoCliente.Text = "--Seleccionar tipo de cliente--";
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
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 265);
            this.dataGridView1.TabIndex = 12;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Cliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            this.Load += new System.EventHandler(this.MantenedorCliente_Load);
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_N_cliente;
        private System.Windows.Forms.TextBox txt_Telefono_contacto;
        private System.Windows.Forms.TextBox txt_Documento_identidad;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
    }
}