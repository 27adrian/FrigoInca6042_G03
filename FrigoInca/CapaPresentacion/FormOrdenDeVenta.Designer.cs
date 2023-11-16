namespace FrigoInca
{
    partial class FormOrdenDeVenta
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
            this.dgv_PedidodeCarne = new System.Windows.Forms.DataGridView();
            this.txt_IdPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IddelProducto = new System.Windows.Forms.TextBox();
            this.txt_IddelCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdOrdendeVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidodeCarne)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(13, 152);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 35;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // dgv_PedidodeCarne
            // 
            this.dgv_PedidodeCarne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PedidodeCarne.Location = new System.Drawing.Point(266, 12);
            this.dgv_PedidodeCarne.Name = "dgv_PedidodeCarne";
            this.dgv_PedidodeCarne.Size = new System.Drawing.Size(509, 261);
            this.dgv_PedidodeCarne.TabIndex = 34;
            // 
            // txt_IdPedido
            // 
            this.txt_IdPedido.Location = new System.Drawing.Point(143, 117);
            this.txt_IdPedido.Name = "txt_IdPedido";
            this.txt_IdPedido.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPedido.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Id Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Id del Producto";
            // 
            // txt_IddelProducto
            // 
            this.txt_IddelProducto.Location = new System.Drawing.Point(143, 84);
            this.txt_IddelProducto.Name = "txt_IddelProducto";
            this.txt_IddelProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_IddelProducto.TabIndex = 24;
            // 
            // txt_IddelCliente
            // 
            this.txt_IddelCliente.Location = new System.Drawing.Point(143, 45);
            this.txt_IddelCliente.Name = "txt_IddelCliente";
            this.txt_IddelCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_IddelCliente.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id del Cliente";
            // 
            // txt_IdOrdendeVenta
            // 
            this.txt_IdOrdendeVenta.Location = new System.Drawing.Point(143, 12);
            this.txt_IdOrdendeVenta.Name = "txt_IdOrdendeVenta";
            this.txt_IdOrdendeVenta.Size = new System.Drawing.Size(100, 20);
            this.txt_IdOrdendeVenta.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id OrdendeVenta";
            // 
            // FormOrdenDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_PedidodeCarne);
            this.Controls.Add(this.txt_IdPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IddelProducto);
            this.Controls.Add(this.txt_IddelCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdOrdendeVenta);
            this.Controls.Add(this.label1);
            this.Name = "FormOrdenDeVenta";
            this.Text = "FormOrdenDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidodeCarne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_PedidodeCarne;
        private System.Windows.Forms.TextBox txt_IdPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IddelProducto;
        private System.Windows.Forms.TextBox txt_IddelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdOrdendeVenta;
        private System.Windows.Forms.Label label1;
    }
}