namespace CapaPresentacion
{
    partial class Mantenedor_Cliente
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
            this.txt_NombreCompleto = new System.Windows.Forms.TextBox();
            this.txt_Telefonocontacto = new System.Windows.Forms.TextBox();
            this.txt_Numerodocumento = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_Idcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Fecharegistro = new System.Windows.Forms.DateTimePicker();
            this.cb_Estadodelcliente = new System.Windows.Forms.CheckBox();
            this.cb_Tipodocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cb_Tipocliente = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDoc1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(16, 54);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo de cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // txt_NombreCompleto
            // 
            this.txt_NombreCompleto.Location = new System.Drawing.Point(176, 85);
            this.txt_NombreCompleto.Name = "txt_NombreCompleto";
            this.txt_NombreCompleto.Size = new System.Drawing.Size(199, 20);
            this.txt_NombreCompleto.TabIndex = 8;
            // 
            // txt_Telefonocontacto
            // 
            this.txt_Telefonocontacto.Location = new System.Drawing.Point(176, 212);
            this.txt_Telefonocontacto.Name = "txt_Telefonocontacto";
            this.txt_Telefonocontacto.Size = new System.Drawing.Size(199, 20);
            this.txt_Telefonocontacto.TabIndex = 9;
            // 
            // txt_Numerodocumento
            // 
            this.txt_Numerodocumento.Location = new System.Drawing.Point(176, 152);
            this.txt_Numerodocumento.Name = "txt_Numerodocumento";
            this.txt_Numerodocumento.Size = new System.Drawing.Size(199, 20);
            this.txt_Numerodocumento.TabIndex = 9;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(176, 181);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(199, 20);
            this.txt_Correo.TabIndex = 10;
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.txt_Idcliente);
            this.gb_Cliente.Controls.Add(this.label2);
            this.gb_Cliente.Controls.Add(this.label1);
            this.gb_Cliente.Controls.Add(this.dt_Fecharegistro);
            this.gb_Cliente.Controls.Add(this.cb_Estadodelcliente);
            this.gb_Cliente.Controls.Add(this.cb_Tipodocumento);
            this.gb_Cliente.Controls.Add(this.lblTipoDoc);
            this.gb_Cliente.Controls.Add(this.cb_Tipocliente);
            this.gb_Cliente.Controls.Add(this.btn_Cancelar);
            this.gb_Cliente.Controls.Add(this.btn_Modificar);
            this.gb_Cliente.Controls.Add(this.btn_Agregar);
            this.gb_Cliente.Controls.Add(this.label4);
            this.gb_Cliente.Controls.Add(this.txt_Correo);
            this.gb_Cliente.Controls.Add(this.txt_Numerodocumento);
            this.gb_Cliente.Controls.Add(this.lblTipoCliente);
            this.gb_Cliente.Controls.Add(this.txt_Telefonocontacto);
            this.gb_Cliente.Controls.Add(this.label3);
            this.gb_Cliente.Controls.Add(this.txt_NombreCompleto);
            this.gb_Cliente.Controls.Add(this.label5);
            this.gb_Cliente.Controls.Add(this.label6);
            this.gb_Cliente.Location = new System.Drawing.Point(12, 298);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(797, 268);
            this.gb_Cliente.TabIndex = 11;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Informacion cliente";
            this.gb_Cliente.Enter += new System.EventHandler(this.gb_Cliente_Enter);
            // 
            // txt_Idcliente
            // 
            this.txt_Idcliente.Location = new System.Drawing.Point(176, 23);
            this.txt_Idcliente.Name = "txt_Idcliente";
            this.txt_Idcliente.Size = new System.Drawing.Size(199, 20);
            this.txt_Idcliente.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id de cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha de registro:";
            // 
            // dt_Fecharegistro
            // 
            this.dt_Fecharegistro.Location = new System.Drawing.Point(429, 195);
            this.dt_Fecharegistro.Name = "dt_Fecharegistro";
            this.dt_Fecharegistro.Size = new System.Drawing.Size(200, 20);
            this.dt_Fecharegistro.TabIndex = 19;
            // 
            // cb_Estadodelcliente
            // 
            this.cb_Estadodelcliente.AutoSize = true;
            this.cb_Estadodelcliente.Location = new System.Drawing.Point(429, 56);
            this.cb_Estadodelcliente.Name = "cb_Estadodelcliente";
            this.cb_Estadodelcliente.Size = new System.Drawing.Size(110, 17);
            this.cb_Estadodelcliente.TabIndex = 18;
            this.cb_Estadodelcliente.Text = "Estado del cliente";
            this.cb_Estadodelcliente.UseVisualStyleBackColor = true;
            // 
            // cb_Tipodocumento
            // 
            this.cb_Tipodocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cb_Tipodocumento.Location = new System.Drawing.Point(176, 121);
            this.cb_Tipodocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Tipodocumento.Name = "cb_Tipodocumento";
            this.cb_Tipodocumento.Size = new System.Drawing.Size(199, 21);
            this.cb_Tipodocumento.TabIndex = 17;
            this.cb_Tipodocumento.Text = "--Seleccionar tipo de documento--";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(16, 123);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(102, 13);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cb_Tipocliente
            // 
            this.cb_Tipocliente.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cb_Tipocliente.Location = new System.Drawing.Point(176, 52);
            this.cb_Tipocliente.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Tipocliente.Name = "cb_Tipocliente";
            this.cb_Tipocliente.Size = new System.Drawing.Size(199, 21);
            this.cb_Tipocliente.TabIndex = 15;
            this.cb_Tipocliente.Text = "--Seleccionar tipo de cliente--";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(681, 123);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 34);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(681, 70);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 35);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(681, 23);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(94, 38);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(55, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 38);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 12);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.RowHeadersWidth = 51;
            this.dgv_Cliente.Size = new System.Drawing.Size(966, 256);
            this.dgv_Cliente.TabIndex = 12;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(993, 18);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(91, 31);
            this.btn_Nuevo.TabIndex = 18;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(993, 66);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(91, 31);
            this.btn_Editar.TabIndex = 19;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Location = new System.Drawing.Point(993, 115);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(91, 31);
            this.btn_Deshabilitar.TabIndex = 20;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Salir.Location = new System.Drawing.Point(887, 510);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(91, 36);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "N° de documento:";
            // 
            // txtNumDoc1
            // 
            this.txtNumDoc1.Location = new System.Drawing.Point(27, 51);
            this.txtNumDoc1.MaxLength = 8;
            this.txtNumDoc1.Name = "txtNumDoc1";
            this.txtNumDoc1.Size = new System.Drawing.Size(154, 20);
            this.txtNumDoc1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumDoc1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(829, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 167);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // Mantenedor_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 578);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.gb_Cliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mantenedor_Cliente";
            this.Text = "Mantenedor_Cliente";
            this.Load += new System.EventHandler(this.MantenedorCliente_Load);
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NombreCompleto;
        private System.Windows.Forms.TextBox txt_Telefonocontacto;
        private System.Windows.Forms.TextBox txt_Numerodocumento;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.ComboBox cb_Tipocliente;
        private System.Windows.Forms.ComboBox cb_Tipodocumento;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Deshabilitar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Fecharegistro;
        private System.Windows.Forms.CheckBox cb_Estadodelcliente;
        private System.Windows.Forms.TextBox txt_Idcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumDoc1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}