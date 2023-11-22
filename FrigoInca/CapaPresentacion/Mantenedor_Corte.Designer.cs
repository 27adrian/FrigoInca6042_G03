namespace FrigoInca
{
    partial class Mantenedor_Corte
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrecorte = new System.Windows.Forms.TextBox();
            this.txtPreciocorte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCorte
            // 
            this.dgvCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorte.Location = new System.Drawing.Point(16, 124);
            this.dgvCorte.Name = "dgvCorte";
            this.dgvCorte.Size = new System.Drawing.Size(464, 150);
            this.dgvCorte.TabIndex = 0;
            this.dgvCorte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CORTES:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Deshabilitar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombrecorte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preciocorte:";
            // 
            // txtNombrecorte
            // 
            this.txtNombrecorte.Location = new System.Drawing.Point(107, 27);
            this.txtNombrecorte.Name = "txtNombrecorte";
            this.txtNombrecorte.Size = new System.Drawing.Size(100, 20);
            this.txtNombrecorte.TabIndex = 7;
            // 
            // txtPreciocorte
            // 
            this.txtPreciocorte.Location = new System.Drawing.Point(107, 61);
            this.txtPreciocorte.Name = "txtPreciocorte";
            this.txtPreciocorte.Size = new System.Drawing.Size(100, 20);
            this.txtPreciocorte.TabIndex = 8;
            // 
            // Mantenedor_Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 298);
            this.Controls.Add(this.txtPreciocorte);
            this.Controls.Add(this.txtNombrecorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrecorte;
        private System.Windows.Forms.TextBox txtPreciocorte;
    }
}