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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cb_Estadodelcliente = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(19, 30);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo de cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // txt_N_cliente
            // 
            this.txt_N_cliente.Location = new System.Drawing.Point(179, 61);
            this.txt_N_cliente.Name = "txt_N_cliente";
            this.txt_N_cliente.Size = new System.Drawing.Size(199, 20);
            this.txt_N_cliente.TabIndex = 8;
            // 
            // txt_Telefono_contacto
            // 
            this.txt_Telefono_contacto.Location = new System.Drawing.Point(179, 188);
            this.txt_Telefono_contacto.Name = "txt_Telefono_contacto";
            this.txt_Telefono_contacto.Size = new System.Drawing.Size(199, 20);
            this.txt_Telefono_contacto.TabIndex = 9;
            // 
            // txt_Documento_identidad
            // 
            this.txt_Documento_identidad.Location = new System.Drawing.Point(179, 128);
            this.txt_Documento_identidad.Name = "txt_Documento_identidad";
            this.txt_Documento_identidad.Size = new System.Drawing.Size(199, 20);
            this.txt_Documento_identidad.TabIndex = 9;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(179, 157);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(199, 20);
            this.txt_Correo.TabIndex = 10;
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.label1);
            this.gb_Cliente.Controls.Add(this.dateTimePicker1);
            this.gb_Cliente.Controls.Add(this.cb_Estadodelcliente);
            this.gb_Cliente.Controls.Add(this.cbxTipoDoc);
            this.gb_Cliente.Controls.Add(this.lblTipoDoc);
            this.gb_Cliente.Controls.Add(this.cbxTipoCliente);
            this.gb_Cliente.Controls.Add(this.btn_Cancelar);
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
            this.gb_Cliente.Location = new System.Drawing.Point(12, 290);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(800, 224);
            this.gb_Cliente.TabIndex = 11;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Informacion cliente";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cbxTipoDoc.Location = new System.Drawing.Point(179, 97);
            this.cbxTipoDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(199, 21);
            this.cbxTipoDoc.TabIndex = 17;
            this.cbxTipoDoc.Text = "--Seleccionar tipo de documento--";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(19, 99);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(102, 13);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(179, 28);
            this.cbxTipoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(199, 21);
            this.cbxTipoCliente.TabIndex = 15;
            this.cbxTipoCliente.Text = "--Seleccionar tipo de cliente--";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(654, 159);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 49);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(654, 97);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 44);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(654, 19);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(125, 49);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(632, 256);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(666, 12);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(125, 49);
            this.btn_Nuevo.TabIndex = 18;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(666, 80);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(125, 49);
            this.btn_Editar.TabIndex = 19;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Location = new System.Drawing.Point(666, 153);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(125, 49);
            this.btn_Deshabilitar.TabIndex = 20;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(666, 219);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(125, 49);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // cb_Estadodelcliente
            // 
            this.cb_Estadodelcliente.AutoSize = true;
            this.cb_Estadodelcliente.Location = new System.Drawing.Point(432, 32);
            this.cb_Estadodelcliente.Name = "cb_Estadodelcliente";
            this.cb_Estadodelcliente.Size = new System.Drawing.Size(110, 17);
            this.cb_Estadodelcliente.TabIndex = 18;
            this.cb_Estadodelcliente.Text = "Estado del cliente";
            this.cb_Estadodelcliente.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de registro:";
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 530);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Cliente);
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
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deshabilitar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cb_Estadodelcliente;
    }
}