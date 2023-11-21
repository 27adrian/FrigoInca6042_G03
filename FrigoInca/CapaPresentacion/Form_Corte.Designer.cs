namespace FrigoInca
{
    partial class Form_Corte
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
            this.dgvCorte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCorte
            // 
            this.dgvCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorte.Location = new System.Drawing.Point(12, 41);
            this.dgvCorte.Name = "dgvCorte";
            this.dgvCorte.Size = new System.Drawing.Size(464, 150);
            this.dgvCorte.TabIndex = 0;
            this.dgvCorte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CORTES:";
            // 
            // Mantenedor_Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCorte);
            this.Name = "Mantenedor_Corte";
            this.Text = "Mantenedor_Corte";
            this.Load += new System.EventHandler(this.Mantenedor_Corte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCorte;
        private System.Windows.Forms.Label label1;
    }
}