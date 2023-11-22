namespace FrigoInca
{
    partial class Core_OrdendeVenta
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvOrdenventa = new System.Windows.Forms.DataGridView();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaventa = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIdloteproducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.cbIdFormapago = new System.Windows.Forms.ComboBox();
            this.txtIdOrdendeventa = new System.Windows.Forms.TextBox();
            this.cbEstadoventa = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(488, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvOrdenventa
            // 
            this.dgvOrdenventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenventa.Location = new System.Drawing.Point(24, 207);
            this.dgvOrdenventa.Name = "dgvOrdenventa";
            this.dgvOrdenventa.Size = new System.Drawing.Size(539, 189);
            this.dgvOrdenventa.TabIndex = 34;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(488, 58);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 36;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Idloteproducto:";
            // 
            // dtFechaventa
            // 
            this.dtFechaventa.Location = new System.Drawing.Point(145, 158);
            this.dtFechaventa.Name = "dtFechaventa";
            this.dtFechaventa.Size = new System.Drawing.Size(200, 20);
            this.dtFechaventa.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "IdCliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "IdDescuento:";
            // 
            // cbIdloteproducto
            // 
            this.cbIdloteproducto.FormattingEnabled = true;
            this.cbIdloteproducto.Location = new System.Drawing.Point(145, 50);
            this.cbIdloteproducto.Name = "cbIdloteproducto";
            this.cbIdloteproducto.Size = new System.Drawing.Size(121, 21);
            this.cbIdloteproducto.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "IdFormapago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "IdOrdendeventa:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(145, 77);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 47;
            // 
            // cbDescuento
            // 
            this.cbDescuento.FormattingEnabled = true;
            this.cbDescuento.Location = new System.Drawing.Point(145, 104);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(121, 21);
            this.cbDescuento.TabIndex = 48;
            // 
            // cbIdFormapago
            // 
            this.cbIdFormapago.FormattingEnabled = true;
            this.cbIdFormapago.Location = new System.Drawing.Point(145, 131);
            this.cbIdFormapago.Name = "cbIdFormapago";
            this.cbIdFormapago.Size = new System.Drawing.Size(121, 21);
            this.cbIdFormapago.TabIndex = 49;
            // 
            // txtIdOrdendeventa
            // 
            this.txtIdOrdendeventa.Location = new System.Drawing.Point(145, 22);
            this.txtIdOrdendeventa.Name = "txtIdOrdendeventa";
            this.txtIdOrdendeventa.Size = new System.Drawing.Size(121, 20);
            this.txtIdOrdendeventa.TabIndex = 50;
            // 
            // cbEstadoventa
            // 
            this.cbEstadoventa.AutoSize = true;
            this.cbEstadoventa.Location = new System.Drawing.Point(295, 29);
            this.cbEstadoventa.Name = "cbEstadoventa";
            this.cbEstadoventa.Size = new System.Drawing.Size(86, 17);
            this.cbEstadoventa.TabIndex = 51;
            this.cbEstadoventa.Text = "Estadoventa";
            this.cbEstadoventa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fechaventa:";
            // 
            // Core_OrdendeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstadoventa);
            this.Controls.Add(this.txtIdOrdendeventa);
            this.Controls.Add(this.cbIdFormapago);
            this.Controls.Add(this.cbDescuento);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbIdloteproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaventa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvOrdenventa);
            this.Name = "Core_OrdendeVenta";
            this.Text = "FormCore_OrdenDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvOrdenventa;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIdloteproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbDescuento;
        private System.Windows.Forms.ComboBox cbIdFormapago;
        private System.Windows.Forms.TextBox txtIdOrdendeventa;
        private System.Windows.Forms.CheckBox cbEstadoventa;
        private System.Windows.Forms.Label label6;
    }
}