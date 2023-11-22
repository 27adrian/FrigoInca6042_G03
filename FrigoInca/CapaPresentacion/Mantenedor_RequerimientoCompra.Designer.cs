namespace FrigoInca
{
    partial class Mantenedor_RequerimientoCompra
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvRequerimientocompra = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdRequerimientocompra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientocompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(216, 121);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(160, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // dgvRequerimientocompra
            // 
            this.dgvRequerimientocompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequerimientocompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientocompra.Location = new System.Drawing.Point(25, 229);
            this.dgvRequerimientocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRequerimientocompra.Name = "dgvRequerimientocompra";
            this.dgvRequerimientocompra.RowHeadersWidth = 51;
            this.dgvRequerimientocompra.Size = new System.Drawing.Size(644, 185);
            this.dgvRequerimientocompra.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(569, 22);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "IdAnimal:";
            // 
            // cbIdAnimal
            // 
            this.cbIdAnimal.FormattingEnabled = true;
            this.cbIdAnimal.Location = new System.Drawing.Point(216, 66);
            this.cbIdAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbIdAnimal.Name = "cbIdAnimal";
            this.cbIdAnimal.Size = new System.Drawing.Size(160, 24);
            this.cbIdAnimal.TabIndex = 14;
            this.cbIdAnimal.SelectedIndexChanged += new System.EventHandler(this.cbIdAnimal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "IdRequerimientocompra:";
            // 
            // txtIdRequerimientocompra
            // 
            this.txtIdRequerimientocompra.Enabled = false;
            this.txtIdRequerimientocompra.Location = new System.Drawing.Point(216, 22);
            this.txtIdRequerimientocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRequerimientocompra.Name = "txtIdRequerimientocompra";
            this.txtIdRequerimientocompra.Size = new System.Drawing.Size(160, 22);
            this.txtIdRequerimientocompra.TabIndex = 16;
            // 
            // Mantenedor_RequerimientoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 438);
            this.Controls.Add(this.txtIdRequerimientocompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIdAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRequerimientocompra);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mantenedor_RequerimientoCompra";
            this.Text = "Mantenedor_RequerimientosCompraMP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientocompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvRequerimientocompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdRequerimientocompra;
    }
}