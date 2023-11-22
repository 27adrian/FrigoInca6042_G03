namespace CapaPresentacion
{
    partial class Mantenedor_Descuento
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcentaje = new System.Windows.Forms.TextBox();
            this.dgvDescuento = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje Descuento";
            // 
            // txtProcentaje
            // 
            this.txtProcentaje.Location = new System.Drawing.Point(205, 28);
            this.txtProcentaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcentaje.Name = "txtProcentaje";
            this.txtProcentaje.Size = new System.Drawing.Size(132, 22);
            this.txtProcentaje.TabIndex = 6;
            // 
            // dgvDescuento
            // 
            this.dgvDescuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuento.Location = new System.Drawing.Point(23, 110);
            this.dgvDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDescuento.Name = "dgvDescuento";
            this.dgvDescuento.RowHeadersWidth = 51;
            this.dgvDescuento.Size = new System.Drawing.Size(521, 170);
            this.dgvDescuento.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 28);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Mantenedor_Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 299);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDescuento);
            this.Controls.Add(this.txtProcentaje);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mantenedor_Descuento";
            this.Text = "Mantenedor_Descuento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcentaje;
        private System.Windows.Forms.DataGridView dgvDescuento;
        private System.Windows.Forms.Button btnAgregar;
    }
}