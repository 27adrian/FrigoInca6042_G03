﻿namespace CapaPresentacion
{
    partial class Mantenedor_Proveedor
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
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUbigeo = new System.Windows.Forms.DataGridView();
            this.txtIdUbigeo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).BeginInit();
            this.gb_Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbigeo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Proveedor
            // 
            this.dgv_Proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proveedor.Location = new System.Drawing.Point(16, 15);
            this.dgv_Proveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Proveedor.Name = "dgv_Proveedor";
            this.dgv_Proveedor.ReadOnly = true;
            this.dgv_Proveedor.RowHeadersWidth = 51;
            this.dgv_Proveedor.Size = new System.Drawing.Size(1316, 310);
            this.dgv_Proveedor.TabIndex = 14;
            this.dgv_Proveedor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proveedor_CellEnter);
            // 
            // gb_Proveedor
            // 
            this.gb_Proveedor.Controls.Add(this.cbAnimal);
            this.gb_Proveedor.Controls.Add(this.label10);
            this.gb_Proveedor.Controls.Add(this.label8);
            this.gb_Proveedor.Controls.Add(this.dgvUbigeo);
            this.gb_Proveedor.Controls.Add(this.txtIdUbigeo);
            this.gb_Proveedor.Controls.Add(this.label9);
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
            this.gb_Proveedor.Location = new System.Drawing.Point(16, 350);
            this.gb_Proveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Proveedor.Name = "gb_Proveedor";
            this.gb_Proveedor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Proveedor.Size = new System.Drawing.Size(1049, 630);
            this.gb_Proveedor.TabIndex = 13;
            this.gb_Proveedor.TabStop = false;
            this.gb_Proveedor.Text = "Informacion Proveedor";
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(229, 161);
            this.cbAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(264, 24);
            this.cbAnimal.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Animal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "UBIGEO:";
            // 
            // dgvUbigeo
            // 
            this.dgvUbigeo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUbigeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbigeo.Location = new System.Drawing.Point(20, 432);
            this.dgvUbigeo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUbigeo.Name = "dgvUbigeo";
            this.dgvUbigeo.ReadOnly = true;
            this.dgvUbigeo.RowHeadersWidth = 51;
            this.dgvUbigeo.Size = new System.Drawing.Size(932, 162);
            this.dgvUbigeo.TabIndex = 31;
            // 
            // txtIdUbigeo
            // 
            this.txtIdUbigeo.Location = new System.Drawing.Point(229, 351);
            this.txtIdUbigeo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdUbigeo.Name = "txtIdUbigeo";
            this.txtIdUbigeo.Size = new System.Drawing.Size(264, 22);
            this.txtIdUbigeo.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Id Ubigeo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha de registro:";
            // 
            // dt_Fechaderegistroproveedor
            // 
            this.dt_Fechaderegistroproveedor.Location = new System.Drawing.Point(573, 311);
            this.dt_Fechaderegistroproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_Fechaderegistroproveedor.Name = "dt_Fechaderegistroproveedor";
            this.dt_Fechaderegistroproveedor.Size = new System.Drawing.Size(265, 22);
            this.dt_Fechaderegistroproveedor.TabIndex = 25;
            // 
            // cb_Estadodelproveedor
            // 
            this.cb_Estadodelproveedor.AutoSize = true;
            this.cb_Estadodelproveedor.Location = new System.Drawing.Point(573, 34);
            this.cb_Estadodelproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Estadodelproveedor.Name = "cb_Estadodelproveedor";
            this.cb_Estadodelproveedor.Size = new System.Drawing.Size(160, 20);
            this.cb_Estadodelproveedor.TabIndex = 24;
            this.cb_Estadodelproveedor.Text = "Estado del proveedor";
            this.cb_Estadodelproveedor.UseVisualStyleBackColor = true;
            // 
            // txt_Idproveedor
            // 
            this.txt_Idproveedor.Location = new System.Drawing.Point(229, 31);
            this.txt_Idproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Idproveedor.Name = "txt_Idproveedor";
            this.txt_Idproveedor.Size = new System.Drawing.Size(264, 22);
            this.txt_Idproveedor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id de Proveedor:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(911, 135);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 42);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(911, 76);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(120, 42);
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cb_Tipodocumento
            // 
            this.cb_Tipodocumento.Enabled = false;
            this.cb_Tipodocumento.Items.AddRange(new object[] {
            "RUC",
            "DNI"});
            this.cb_Tipodocumento.Location = new System.Drawing.Point(229, 201);
            this.cb_Tipodocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Tipodocumento.Name = "cb_Tipodocumento";
            this.cb_Tipodocumento.Size = new System.Drawing.Size(264, 24);
            this.cb_Tipodocumento.TabIndex = 17;
            this.cb_Tipodocumento.Text = "--Seleccionar tipo de documento--";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(16, 203);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(127, 16);
            this.lblTipoDoc.TabIndex = 16;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // cb_Tipoproveedor
            // 
            this.cb_Tipoproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipoproveedor.Items.AddRange(new object[] {
            "Empresa",
            "Independiente"});
            this.cb_Tipoproveedor.Location = new System.Drawing.Point(229, 74);
            this.cb_Tipoproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Tipoproveedor.Name = "cb_Tipoproveedor";
            this.cb_Tipoproveedor.Size = new System.Drawing.Size(264, 24);
            this.cb_Tipoproveedor.TabIndex = 15;
            this.cb_Tipoproveedor.SelectedIndexChanged += new System.EventHandler(this.cb_Tipoproveedor_SelectedIndexChanged_1);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(911, 25);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(120, 42);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de documento:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(229, 274);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(264, 22);
            this.txt_Correo.TabIndex = 10;
            // 
            // txt_Numerodocumento
            // 
            this.txt_Numerodocumento.Location = new System.Drawing.Point(229, 239);
            this.txt_Numerodocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Numerodocumento.MaxLength = 8;
            this.txt_Numerodocumento.Name = "txt_Numerodocumento";
            this.txt_Numerodocumento.Size = new System.Drawing.Size(264, 22);
            this.txt_Numerodocumento.TabIndex = 9;
            // 
            // lblTipoProveedor
            // 
            this.lblTipoProveedor.AutoSize = true;
            this.lblTipoProveedor.Location = new System.Drawing.Point(16, 76);
            this.lblTipoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoProveedor.Name = "lblTipoProveedor";
            this.lblTipoProveedor.Size = new System.Drawing.Size(124, 16);
            this.lblTipoProveedor.TabIndex = 1;
            this.lblTipoProveedor.Text = "Tipo de Proveedor:";
            // 
            // txt_Telefonocontacto
            // 
            this.txt_Telefonocontacto.Location = new System.Drawing.Point(229, 313);
            this.txt_Telefonocontacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Telefonocontacto.MaxLength = 9;
            this.txt_Telefonocontacto.Name = "txt_Telefonocontacto";
            this.txt_Telefonocontacto.Size = new System.Drawing.Size(264, 22);
            this.txt_Telefonocontacto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // txt_Nombrecompleto
            // 
            this.txt_Nombrecompleto.Location = new System.Drawing.Point(229, 114);
            this.txt_Nombrecompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombrecompleto.Name = "txt_Nombrecompleto";
            this.txt_Nombrecompleto.Size = new System.Drawing.Size(264, 22);
            this.txt_Nombrecompleto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1163, 485);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 39);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(1340, 68);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(124, 60);
            this.btn_Nuevo.TabIndex = 18;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(1340, 150);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(124, 58);
            this.Btn_Editar.TabIndex = 19;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Location = new System.Drawing.Point(1340, 231);
            this.btn_Deshabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(124, 50);
            this.btn_Deshabilitar.TabIndex = 20;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1167, 612);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(124, 43);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1163, 400);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "N° de documento:";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(1112, 436);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumDoc.MaxLength = 8;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(239, 22);
            this.txtNumDoc.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1097, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(269, 213);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // Mantenedor_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 994);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dgv_Proveedor);
            this.Controls.Add(this.gb_Proveedor);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mantenedor_Proveedor";
            this.Text = "Mantenedor_Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).EndInit();
            this.gb_Proveedor.ResumeLayout(false);
            this.gb_Proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbigeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdUbigeo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUbigeo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAnimal;
    }
}