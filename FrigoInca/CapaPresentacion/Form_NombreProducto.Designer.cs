namespace FrigoInca
{
    partial class Form_NombreProducto
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
            this.dgvNombreproducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombreproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNombreproducto
            // 
            this.dgvNombreproducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNombreproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNombreproducto.Location = new System.Drawing.Point(16, 107);
            this.dgvNombreproducto.Name = "dgvNombreproducto";
            this.dgvNombreproducto.Size = new System.Drawing.Size(410, 150);
            this.dgvNombreproducto.TabIndex = 0;
            this.dgvNombreproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNombreproducto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE PRODUCTO:";
            // 
            // Form_NombreProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNombreproducto);
            this.Name = "Form_NombreProducto";
            this.Text = "NombreProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombreproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNombreproducto;
        private System.Windows.Forms.Label label1;
    }
}