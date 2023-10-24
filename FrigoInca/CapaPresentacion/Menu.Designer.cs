namespace CapaPresentacion
{
    partial class Menu
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
            this.btnMNotaReclamo = new System.Windows.Forms.Button();
            this.btnMProveedor = new System.Windows.Forms.Button();
            this.btnRIngresoMP = new System.Windows.Forms.Button();
            this.btnMCliente = new System.Windows.Forms.Button();
            this.btnRPedidoCarne = new System.Windows.Forms.Button();
            this.btnROrdenVent = new System.Windows.Forms.Button();
            this.btnMDesct = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMNotaReclamo
            // 
            this.btnMNotaReclamo.Location = new System.Drawing.Point(27, 23);
            this.btnMNotaReclamo.Name = "btnMNotaReclamo";
            this.btnMNotaReclamo.Size = new System.Drawing.Size(129, 48);
            this.btnMNotaReclamo.TabIndex = 0;
            this.btnMNotaReclamo.Text = "Mantenedor Nota de Reclamo";
            this.btnMNotaReclamo.UseVisualStyleBackColor = true;
            // 
            // btnMProveedor
            // 
            this.btnMProveedor.Location = new System.Drawing.Point(174, 23);
            this.btnMProveedor.Name = "btnMProveedor";
            this.btnMProveedor.Size = new System.Drawing.Size(129, 48);
            this.btnMProveedor.TabIndex = 1;
            this.btnMProveedor.Text = "Mantenedor Proveedor";
            this.btnMProveedor.UseVisualStyleBackColor = true;
            // 
            // btnRIngresoMP
            // 
            this.btnRIngresoMP.Location = new System.Drawing.Point(102, 185);
            this.btnRIngresoMP.Name = "btnRIngresoMP";
            this.btnRIngresoMP.Size = new System.Drawing.Size(129, 48);
            this.btnRIngresoMP.TabIndex = 2;
            this.btnRIngresoMP.Text = "Realiza Ingreso Materia Prima";
            this.btnRIngresoMP.UseVisualStyleBackColor = true;
            // 
            // btnMCliente
            // 
            this.btnMCliente.Location = new System.Drawing.Point(174, 77);
            this.btnMCliente.Name = "btnMCliente";
            this.btnMCliente.Size = new System.Drawing.Size(129, 48);
            this.btnMCliente.TabIndex = 3;
            this.btnMCliente.Text = "Mantenedor Cliente";
            this.btnMCliente.UseVisualStyleBackColor = true;
            this.btnMCliente.Click += new System.EventHandler(this.btnMCliente_Click);
            // 
            // btnRPedidoCarne
            // 
            this.btnRPedidoCarne.Location = new System.Drawing.Point(27, 131);
            this.btnRPedidoCarne.Name = "btnRPedidoCarne";
            this.btnRPedidoCarne.Size = new System.Drawing.Size(129, 48);
            this.btnRPedidoCarne.TabIndex = 4;
            this.btnRPedidoCarne.Text = "Realiza Pedido De Carne";
            this.btnRPedidoCarne.UseVisualStyleBackColor = true;
            // 
            // btnROrdenVent
            // 
            this.btnROrdenVent.Location = new System.Drawing.Point(174, 131);
            this.btnROrdenVent.Name = "btnROrdenVent";
            this.btnROrdenVent.Size = new System.Drawing.Size(129, 48);
            this.btnROrdenVent.TabIndex = 5;
            this.btnROrdenVent.Text = "Realiza Orden de Venta";
            this.btnROrdenVent.UseVisualStyleBackColor = true;
            // 
            // btnMDesct
            // 
            this.btnMDesct.Location = new System.Drawing.Point(27, 77);
            this.btnMDesct.Name = "btnMDesct";
            this.btnMDesct.Size = new System.Drawing.Size(129, 48);
            this.btnMDesct.TabIndex = 6;
            this.btnMDesct.Text = "Mantenedor Descuento";
            this.btnMDesct.UseVisualStyleBackColor = true;
            this.btnMDesct.Click += new System.EventHandler(this.btnMDesct_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 48);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 366);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMDesct);
            this.Controls.Add(this.btnROrdenVent);
            this.Controls.Add(this.btnRPedidoCarne);
            this.Controls.Add(this.btnMCliente);
            this.Controls.Add(this.btnRIngresoMP);
            this.Controls.Add(this.btnMProveedor);
            this.Controls.Add(this.btnMNotaReclamo);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMNotaReclamo;
        private System.Windows.Forms.Button btnMProveedor;
        private System.Windows.Forms.Button btnRIngresoMP;
        private System.Windows.Forms.Button btnMCliente;
        private System.Windows.Forms.Button btnRPedidoCarne;
        private System.Windows.Forms.Button btnROrdenVent;
        private System.Windows.Forms.Button btnMDesct;
        private System.Windows.Forms.Button btnSalir;
    }
}