namespace CapaPresentacion
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
            this.dgv_Proveedor = new System.Windows.Forms.DataGridView();
            this.gb_Proveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Fechaderegistroproveedor = new System.Windows.Forms.DateTimePicker();
            this.cb_Estadodelproveedor = new System.Windows.Forms.CheckBox();
            this.txt_Idproveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cb_Tipodocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cb_Tipoproveedor = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Numerodocumento = new System.Windows.Forms.TextBox();
            this.lblTipoProveedor = new System.Windows.Forms.Label();
            this.txt_Telefonocontacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombrecompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnHabilBusque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).BeginInit();
            this.gb_Proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Proveedor
            // 
            this.dgv_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proveedor.Location = new System.Drawing.Point(12, 12);
            this.dgv_Proveedor.Name = "dgv_Proveedor";
            this.dgv_Proveedor.ReadOnly = true;
            this.dgv_Proveedor.RowHeadersWidth = 51;
            this.dgv_Proveedor.Size = new System.Drawing.Size(1002, 252);
            this.dgv_Proveedor.TabIndex = 14;
            // 
            // gb_Proveedor
            // 
            this.gb_Proveedor.Controls.Add(this.btnBuscar);
            this.gb_Proveedor.Controls.Add(this.label2);
            this.gb_Proveedor.Controls.Add(this.dt_Fechaderegistroproveedor);
            this.gb_Proveedor.Controls.Add(this.cb_Estadodelproveedor);
            this.gb_Proveedor.Controls.Add(this.txt_Idproveedor);
            this.gb_Proveedor.Controls.Add(this.label1);
            this.gb_Proveedor.Controls.Add(this.btn_Cancelar);
            this.gb_Proveedor.Controls.Add(this.btn_Modificar);
            this.gb_Proveedor.Controls.Add(this.cb_Tipodocumento);
            this.gb_Proveedor.Controls.Add(this.lblTipoDoc);
            this.gb_Proveedor.Controls.Add(this.cb_Tipoproveedor);
            this.gb_Proveedor.Controls.Add(this.btn_Agregar);
            this.gb_Proveedor.Controls.Add(this.label4);
            this.gb_Proveedor.Controls.Add(this.txt_Correo);
            this.gb_Proveedor.Controls.Add(this.txt_Numerodocumento);
            this.gb_Proveedor.Controls.Add(this.lblTipoProveedor);
            this.gb_Proveedor.Controls.Add(this.txt_Telefonocontacto);
            this.gb_Proveedor.Controls.Add(this.label3);
            this.gb_Proveedor.Controls.Add(this.txt_Nombrecompleto);
            this.gb_Proveedor.Controls.Add(this.label5);
            this.gb_Proveedor.Controls.Add(this.label6);
            this.gb_Proveedor.Location = new System.Drawing.Point(12, 284);
            this.gb_Proveedor.Name = "gb_Proveedor";
            this.gb_Proveedor.Size = new System.Drawing.Size(1150, 255);
            this.gb_Proveedor.TabIndex = 13;
            this.gb_Proveedor.TabStop = false;
            this.gb_Proveedor.Text = "Informacion Proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(843, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 47);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha de registro:";
            // 
            // dt_Fechaderegistroproveedor
            // 
            this.dt_Fechaderegistroproveedor.Location = new System.Drawing.Point(430, 213);
            this.dt_Fechaderegistroproveedor.Name = "dt_Fechaderegistroproveedor";
            this.dt_Fechaderegistroproveedor.Size = new System.Drawing.Size(200, 20);
            this.dt_Fechaderegistroproveedor.TabIndex = 25;
            // 
            // cb_Estadodelproveedor
            // 
            this.cb_Estadodelproveedor.AutoSize = true;
            this.cb_Estadodelproveedor.Location = new System.Drawing.Point(430, 28);
            this.cb_Estadodelproveedor.Name = "cb_Estadodelproveedor";
            this.cb_Estadodelproveedor.Size = new System.Drawing.Size(127, 17);
            this.cb_Estadodelproveedor.TabIndex = 24;
            this.cb_Estadodelproveedor.Text = "Estado del proveedor";
            this.cb_Estadodelproveedor.UseVisualStyleBackColor = true;
            // 
            // txt_Idproveedor
            // 
            this.txt_Idproveedor.Location = new System.Drawing.Point(172, 25);
            this.txt_Idproveedor.Name = "txt_Idproveedor";
            this.txt_Idproveedor.Size = new System.Drawing.Size(199, 20);
            this.txt_Idproveedor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id de Proveedor:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(1008, 180);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 49);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(1008, 109);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 49);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cb_Tipodocumento
            // 
            this.cb_Tipodocumento.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cb_Tipodocumento.Location = new System.Drawing.Point(172, 129);
            this.cb_Tipodocumento.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Tipodocumento.Name = "cb_Tipodocumento";
            this.cb_Tipodocumento.Size = new System.Drawing.Size(199, 21);
            this.cb_Tipodocumento.TabIndex = 17;
            this.cb_Tipodocumento.Text = "--Seleccionar tipo de documento--";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(12, 131);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(102, 13);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cb_Tipoproveedor
            // 
            this.cb_Tipoproveedor.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cb_Tipoproveedor.Location = new System.Drawing.Point(172, 60);
            this.cb_Tipoproveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Tipoproveedor.Name = "cb_Tipoproveedor";
            this.cb_Tipoproveedor.Size = new System.Drawing.Size(199, 21);
            this.cb_Tipoproveedor.TabIndex = 15;
            this.cb_Tipoproveedor.Text = "--Seleccionar tipo de proveedor--";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(1008, 28);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(125, 49);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de documento:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(172, 189);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(199, 20);
            this.txt_Correo.TabIndex = 10;
            // 
            // txt_Numerodocumento
            // 
            this.txt_Numerodocumento.Location = new System.Drawing.Point(172, 160);
            this.txt_Numerodocumento.Name = "txt_Numerodocumento";
            this.txt_Numerodocumento.Size = new System.Drawing.Size(199, 20);
            this.txt_Numerodocumento.TabIndex = 9;
            // 
            // lblTipoProveedor
            // 
            this.lblTipoProveedor.AutoSize = true;
            this.lblTipoProveedor.Location = new System.Drawing.Point(12, 62);
            this.lblTipoProveedor.Name = "lblTipoProveedor";
            this.lblTipoProveedor.Size = new System.Drawing.Size(98, 13);
            this.lblTipoProveedor.TabIndex = 1;
            this.lblTipoProveedor.Text = "Tipo de Proveedor:";
            // 
            // txt_Telefonocontacto
            // 
            this.txt_Telefonocontacto.Location = new System.Drawing.Point(172, 220);
            this.txt_Telefonocontacto.Name = "txt_Telefonocontacto";
            this.txt_Telefonocontacto.Size = new System.Drawing.Size(199, 20);
            this.txt_Telefonocontacto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // txt_Nombrecompleto
            // 
            this.txt_Nombrecompleto.Location = new System.Drawing.Point(172, 93);
            this.txt_Nombrecompleto.Name = "txt_Nombrecompleto";
            this.txt_Nombrecompleto.Size = new System.Drawing.Size(199, 20);
            this.txt_Nombrecompleto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(1020, 12);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(125, 49);
            this.btn_Nuevo.TabIndex = 18;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(1020, 67);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(125, 49);
            this.Btn_Editar.TabIndex = 19;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Location = new System.Drawing.Point(1020, 122);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(125, 49);
            this.btn_Deshabilitar.TabIndex = 20;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1020, 229);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(125, 49);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btnHabilBusque
            // 
            this.btnHabilBusque.Location = new System.Drawing.Point(1021, 178);
            this.btnHabilBusque.Name = "btnHabilBusque";
            this.btnHabilBusque.Size = new System.Drawing.Size(124, 45);
            this.btnHabilBusque.TabIndex = 22;
            this.btnHabilBusque.Text = "Habilitar Busqueda";
            this.btnHabilBusque.UseVisualStyleBackColor = true;
            this.btnHabilBusque.Click += new System.EventHandler(this.btnHabilBusque_Click);
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 551);
            this.Controls.Add(this.btnHabilBusque);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dgv_Proveedor);
            this.Controls.Add(this.gb_Proveedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).EndInit();
            this.gb_Proveedor.ResumeLayout(false);
            this.gb_Proveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Proveedor;
        private System.Windows.Forms.GroupBox gb_Proveedor;
        private System.Windows.Forms.ComboBox cb_Tipodocumento;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cb_Tipoproveedor;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Numerodocumento;
        private System.Windows.Forms.Label lblTipoProveedor;
        private System.Windows.Forms.TextBox txt_Telefonocontacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombrecompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Idproveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button btn_Deshabilitar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.CheckBox cb_Estadodelproveedor;
        private System.Windows.Forms.DateTimePicker dt_Fechaderegistroproveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnHabilBusque;
    }
}