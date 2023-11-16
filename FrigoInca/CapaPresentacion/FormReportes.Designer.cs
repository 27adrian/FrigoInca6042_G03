namespace FrigoInca
{
    partial class FormReportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Utilidad = new System.Windows.Forms.Button();
            this.btn_Ganancia = new System.Windows.Forms.Button();
            this.btn_Gastos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Utilidad
            // 
            this.btn_Utilidad.Location = new System.Drawing.Point(203, 12);
            this.btn_Utilidad.Name = "btn_Utilidad";
            this.btn_Utilidad.Size = new System.Drawing.Size(75, 23);
            this.btn_Utilidad.TabIndex = 2;
            this.btn_Utilidad.Text = "Utilidad";
            this.btn_Utilidad.UseVisualStyleBackColor = true;
            // 
            // btn_Ganancia
            // 
            this.btn_Ganancia.Location = new System.Drawing.Point(12, 12);
            this.btn_Ganancia.Name = "btn_Ganancia";
            this.btn_Ganancia.Size = new System.Drawing.Size(75, 23);
            this.btn_Ganancia.TabIndex = 3;
            this.btn_Ganancia.Text = "Ganancia";
            this.btn_Ganancia.UseVisualStyleBackColor = true;
            this.btn_Ganancia.Click += new System.EventHandler(this.btn_Ganancia_Click);
            // 
            // btn_Gastos
            // 
            this.btn_Gastos.Location = new System.Drawing.Point(105, 12);
            this.btn_Gastos.Name = "btn_Gastos";
            this.btn_Gastos.Size = new System.Drawing.Size(75, 23);
            this.btn_Gastos.TabIndex = 4;
            this.btn_Gastos.Text = "Gastos";
            this.btn_Gastos.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 275);
            this.Controls.Add(this.btn_Gastos);
            this.Controls.Add(this.btn_Ganancia);
            this.Controls.Add(this.btn_Utilidad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReportes";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Utilidad;
        private System.Windows.Forms.Button btn_Ganancia;
        private System.Windows.Forms.Button btn_Gastos;
    }
}