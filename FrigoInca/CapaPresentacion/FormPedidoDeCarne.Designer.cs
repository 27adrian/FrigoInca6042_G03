namespace FrigoInca
{
    partial class FormPedidoDeCarne
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
            this.txt_IddelPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IddelCliente = new System.Windows.Forms.TextBox();
            this.txt_IddelProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Corte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_FechayHoradeEntrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MetododePago = new System.Windows.Forms.TextBox();
            this.dgv_PedidodeCarne = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidodeCarne)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Pedido";
            // 
            // txt_IddelPedido
            // 
            this.txt_IddelPedido.Location = new System.Drawing.Point(156, 23);
            this.txt_IddelPedido.Name = "txt_IddelPedido";
            this.txt_IddelPedido.Size = new System.Drawing.Size(100, 20);
            this.txt_IddelPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id del Cliente";
            // 
            // txt_IddelCliente
            // 
            this.txt_IddelCliente.Location = new System.Drawing.Point(156, 56);
            this.txt_IddelCliente.Name = "txt_IddelCliente";
            this.txt_IddelCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_IddelCliente.TabIndex = 3;
            // 
            // txt_IddelProducto
            // 
            this.txt_IddelProducto.Location = new System.Drawing.Point(156, 95);
            this.txt_IddelProducto.Name = "txt_IddelProducto";
            this.txt_IddelProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_IddelProducto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Corte";
            // 
            // txt_Corte
            // 
            this.txt_Corte.Location = new System.Drawing.Point(156, 128);
            this.txt_Corte.Name = "txt_Corte";
            this.txt_Corte.Size = new System.Drawing.Size(100, 20);
            this.txt_Corte.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(156, 166);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha y Hora de Entrega";
            // 
            // txt_FechayHoradeEntrega
            // 
            this.txt_FechayHoradeEntrega.Location = new System.Drawing.Point(156, 200);
            this.txt_FechayHoradeEntrega.Name = "txt_FechayHoradeEntrega";
            this.txt_FechayHoradeEntrega.Size = new System.Drawing.Size(100, 20);
            this.txt_FechayHoradeEntrega.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Metodo de Pago:";
            // 
            // txt_MetododePago
            // 
            this.txt_MetododePago.Location = new System.Drawing.Point(156, 236);
            this.txt_MetododePago.Name = "txt_MetododePago";
            this.txt_MetododePago.Size = new System.Drawing.Size(100, 20);
            this.txt_MetododePago.TabIndex = 15;
            // 
            // dgv_PedidodeCarne
            // 
            this.dgv_PedidodeCarne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PedidodeCarne.Location = new System.Drawing.Point(279, 23);
            this.dgv_PedidodeCarne.Name = "dgv_PedidodeCarne";
            this.dgv_PedidodeCarne.Size = new System.Drawing.Size(509, 261);
            this.dgv_PedidodeCarne.TabIndex = 16;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(26, 270);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // FormPedidoDeCarne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_PedidodeCarne);
            this.Controls.Add(this.txt_MetododePago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_FechayHoradeEntrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Corte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IddelProducto);
            this.Controls.Add(this.txt_IddelCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IddelPedido);
            this.Controls.Add(this.label1);
            this.Name = "FormPedidoDeCarne";
            this.Text = "FromPedidoDeCarne";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PedidodeCarne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IddelPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IddelCliente;
        private System.Windows.Forms.TextBox txt_IddelProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Corte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FechayHoradeEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MetododePago;
        private System.Windows.Forms.DataGridView dgv_PedidodeCarne;
        private System.Windows.Forms.Button btn_Agregar;
    }
}