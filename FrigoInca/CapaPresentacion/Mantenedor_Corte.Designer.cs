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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrecorte = new System.Windows.Forms.TextBox();
            this.txtPreciocorte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCorte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCorte
            // 
            this.dgvCorte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorte.Location = new System.Drawing.Point(21, 186);
            this.dgvCorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCorte.Name = "dgvCorte";
            this.dgvCorte.RowHeadersWidth = 51;
            this.dgvCorte.Size = new System.Drawing.Size(619, 185);
            this.dgvCorte.TabIndex = 0;
            this.dgvCorte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CORTES:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombrecorte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preciocorte:";
            // 
            // txtNombrecorte
            // 
            this.txtNombrecorte.Location = new System.Drawing.Point(143, 66);
            this.txtNombrecorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrecorte.Name = "txtNombrecorte";
            this.txtNombrecorte.Size = new System.Drawing.Size(132, 22);
            this.txtNombrecorte.TabIndex = 7;
            // 
            // txtPreciocorte
            // 
            this.txtPreciocorte.Location = new System.Drawing.Point(143, 108);
            this.txtPreciocorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreciocorte.Name = "txtPreciocorte";
            this.txtPreciocorte.Size = new System.Drawing.Size(132, 22);
            this.txtPreciocorte.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "IdCorte:";
            // 
            // txtIdCorte
            // 
            this.txtIdCorte.Location = new System.Drawing.Point(143, 34);
            this.txtIdCorte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCorte.Name = "txtIdCorte";
            this.txtIdCorte.Size = new System.Drawing.Size(132, 22);
            this.txtIdCorte.TabIndex = 10;
            // 
            // Mantenedor_Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 423);
            this.Controls.Add(this.txtIdCorte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreciocorte);
            this.Controls.Add(this.txtNombrecorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCorte);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrecorte;
        private System.Windows.Forms.TextBox txtPreciocorte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCorte;
    }
}