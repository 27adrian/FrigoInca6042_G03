namespace FrigoInca
{
    partial class FormCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombredelCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DirecciondeEntrega = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Productos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_FechayHoradeEntrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MetododePago = new System.Windows.Forms.TextBox();
            this.dgv_Compras = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // txt_NombredelCliente
            // 
            this.txt_NombredelCliente.Location = new System.Drawing.Point(156, 23);
            this.txt_NombredelCliente.Name = "txt_NombredelCliente";
            this.txt_NombredelCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_NombredelCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion de Entrega:";
            // 
            // txt_DirecciondeEntrega
            // 
            this.txt_DirecciondeEntrega.Location = new System.Drawing.Point(156, 56);
            this.txt_DirecciondeEntrega.Name = "txt_DirecciondeEntrega";
            this.txt_DirecciondeEntrega.Size = new System.Drawing.Size(100, 20);
            this.txt_DirecciondeEntrega.TabIndex = 3;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(156, 95);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo Electronico:";
            // 
            // txt_CorreoElectronico
            // 
            this.txt_CorreoElectronico.Location = new System.Drawing.Point(156, 128);
            this.txt_CorreoElectronico.Name = "txt_CorreoElectronico";
            this.txt_CorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.txt_CorreoElectronico.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Productos:";
            // 
            // txt_Productos
            // 
            this.txt_Productos.Location = new System.Drawing.Point(156, 158);
            this.txt_Productos.Name = "txt_Productos";
            this.txt_Productos.Size = new System.Drawing.Size(100, 20);
            this.txt_Productos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(156, 194);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha y Hora de Entrega";
            // 
            // txt_FechayHoradeEntrega
            // 
            this.txt_FechayHoradeEntrega.Location = new System.Drawing.Point(156, 228);
            this.txt_FechayHoradeEntrega.Name = "txt_FechayHoradeEntrega";
            this.txt_FechayHoradeEntrega.Size = new System.Drawing.Size(100, 20);
            this.txt_FechayHoradeEntrega.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Metodo de Pago:";
            // 
            // txt_MetododePago
            // 
            this.txt_MetododePago.Location = new System.Drawing.Point(156, 264);
            this.txt_MetododePago.Name = "txt_MetododePago";
            this.txt_MetododePago.Size = new System.Drawing.Size(100, 20);
            this.txt_MetododePago.TabIndex = 15;
            // 
            // dgv_Compras
            // 
            this.dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Compras.Location = new System.Drawing.Point(279, 23);
            this.dgv_Compras.Name = "dgv_Compras";
            this.dgv_Compras.Size = new System.Drawing.Size(509, 261);
            this.dgv_Compras.TabIndex = 16;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(26, 312);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(181, 312);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(104, 312);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Compras);
            this.Controls.Add(this.txt_MetododePago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_FechayHoradeEntrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Productos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CorreoElectronico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_DirecciondeEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NombredelCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombredelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DirecciondeEntrega;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FechayHoradeEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MetododePago;
        private System.Windows.Forms.DataGridView dgv_Compras;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
    }
}