namespace FrigoInca
{
    partial class Form_Lote
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
            this.dgvMateriaPrima = new System.Windows.Forms.DataGridView();
            this.gb_Lote = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadCarne = new System.Windows.Forms.TextBox();
            this.rBtnDerivado = new System.Windows.Forms.RadioButton();
            this.rBtnCorte = new System.Windows.Forms.RadioButton();
            this.tBxTipoCarne = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIDmp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cBxProducto = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoCarne = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPesoCarne = new System.Windows.Forms.TextBox();
            this.dgvLoteProducto = new System.Windows.Forms.DataGridView();
            this.tbxIDmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).BeginInit();
            this.gb_Lote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriaPrima
            // 
            this.dgvMateriaPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriaPrima.ColumnHeadersHeight = 29;
            this.dgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMateriaPrima.Location = new System.Drawing.Point(435, 22);
            this.dgvMateriaPrima.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMateriaPrima.Name = "dgvMateriaPrima";
            this.dgvMateriaPrima.RowHeadersWidth = 51;
            this.dgvMateriaPrima.Size = new System.Drawing.Size(366, 373);
            this.dgvMateriaPrima.TabIndex = 14;
            this.dgvMateriaPrima.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriaPrima_CellEnter);
            // 
            // gb_Lote
            // 
            this.gb_Lote.Controls.Add(this.tbxIDmp);
            this.gb_Lote.Controls.Add(this.lblCantidad);
            this.gb_Lote.Controls.Add(this.txtCantidadCarne);
            this.gb_Lote.Controls.Add(this.rBtnDerivado);
            this.gb_Lote.Controls.Add(this.rBtnCorte);
            this.gb_Lote.Controls.Add(this.tBxTipoCarne);
            this.gb_Lote.Controls.Add(this.lblProducto);
            this.gb_Lote.Controls.Add(this.lblIDmp);
            this.gb_Lote.Controls.Add(this.dateTimePicker1);
            this.gb_Lote.Controls.Add(this.cBxProducto);
            this.gb_Lote.Controls.Add(this.btn_Eliminar);
            this.gb_Lote.Controls.Add(this.btn_Agregar);
            this.gb_Lote.Controls.Add(this.lblFecha);
            this.gb_Lote.Controls.Add(this.lblTipoCarne);
            this.gb_Lote.Controls.Add(this.lblPeso);
            this.gb_Lote.Controls.Add(this.txtPesoCarne);
            this.gb_Lote.Location = new System.Drawing.Point(13, 22);
            this.gb_Lote.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Lote.Name = "gb_Lote";
            this.gb_Lote.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Lote.Size = new System.Drawing.Size(414, 373);
            this.gb_Lote.TabIndex = 13;
            this.gb_Lote.TabStop = false;
            this.gb_Lote.Text = "Informacion lote";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(8, 221);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 30;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidadCarne
            // 
            this.txtCantidadCarne.Location = new System.Drawing.Point(141, 218);
            this.txtCantidadCarne.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadCarne.Name = "txtCantidadCarne";
            this.txtCantidadCarne.Size = new System.Drawing.Size(99, 22);
            this.txtCantidadCarne.TabIndex = 31;
            // 
            // rBtnDerivado
            // 
            this.rBtnDerivado.AutoSize = true;
            this.rBtnDerivado.Location = new System.Drawing.Point(249, 34);
            this.rBtnDerivado.Name = "rBtnDerivado";
            this.rBtnDerivado.Size = new System.Drawing.Size(84, 20);
            this.rBtnDerivado.TabIndex = 29;
            this.rBtnDerivado.TabStop = true;
            this.rBtnDerivado.Text = "Derivado";
            this.rBtnDerivado.UseVisualStyleBackColor = true;
            this.rBtnDerivado.CheckedChanged += new System.EventHandler(this.rBtnDerivado_CheckedChanged);
            // 
            // rBtnCorte
            // 
            this.rBtnCorte.AutoSize = true;
            this.rBtnCorte.Checked = true;
            this.rBtnCorte.Location = new System.Drawing.Point(63, 34);
            this.rBtnCorte.Name = "rBtnCorte";
            this.rBtnCorte.Size = new System.Drawing.Size(60, 20);
            this.rBtnCorte.TabIndex = 28;
            this.rBtnCorte.TabStop = true;
            this.rBtnCorte.Text = "Corte";
            this.rBtnCorte.UseVisualStyleBackColor = true;
            this.rBtnCorte.CheckedChanged += new System.EventHandler(this.rBtnCorte_CheckedChanged);
            // 
            // tBxTipoCarne
            // 
            this.tBxTipoCarne.Location = new System.Drawing.Point(141, 105);
            this.tBxTipoCarne.Margin = new System.Windows.Forms.Padding(4);
            this.tBxTipoCarne.Name = "tBxTipoCarne";
            this.tBxTipoCarne.Size = new System.Drawing.Size(260, 22);
            this.tBxTipoCarne.TabIndex = 27;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(8, 140);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 16);
            this.lblProducto.TabIndex = 26;
            this.lblProducto.Text = "Producto";
            // 
            // lblIDmp
            // 
            this.lblIDmp.AutoSize = true;
            this.lblIDmp.Location = new System.Drawing.Point(8, 76);
            this.lblIDmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDmp.Name = "lblIDmp";
            this.lblIDmp.Size = new System.Drawing.Size(103, 16);
            this.lblIDmp.TabIndex = 24;
            this.lblIDmp.Text = "IDMateria Prima";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 250);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // cBxProducto
            // 
            this.cBxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxProducto.Items.AddRange(new object[] {
            "Res",
            "Cerdo",
            "Pollo"});
            this.cBxProducto.Location = new System.Drawing.Point(141, 137);
            this.cBxProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBxProducto.Name = "cBxProducto";
            this.cBxProducto.Size = new System.Drawing.Size(260, 24);
            this.cBxProducto.TabIndex = 15;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(30, 297);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(167, 60);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Deshabilitar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(214, 297);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(167, 60);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 256);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(115, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de ingreso:";
            // 
            // lblTipoCarne
            // 
            this.lblTipoCarne.AutoSize = true;
            this.lblTipoCarne.Location = new System.Drawing.Point(8, 108);
            this.lblTipoCarne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCarne.Name = "lblTipoCarne";
            this.lblTipoCarne.Size = new System.Drawing.Size(94, 16);
            this.lblTipoCarne.TabIndex = 1;
            this.lblTipoCarne.Text = "Tipo de carne:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(8, 179);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(68, 16);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // txtPesoCarne
            // 
            this.txtPesoCarne.Location = new System.Drawing.Point(142, 176);
            this.txtPesoCarne.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoCarne.Name = "txtPesoCarne";
            this.txtPesoCarne.Size = new System.Drawing.Size(99, 22);
            this.txtPesoCarne.TabIndex = 8;
            // 
            // dgvLoteProducto
            // 
            this.dgvLoteProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoteProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoteProducto.Location = new System.Drawing.Point(809, 22);
            this.dgvLoteProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoteProducto.Name = "dgvLoteProducto";
            this.dgvLoteProducto.ReadOnly = true;
            this.dgvLoteProducto.RowHeadersWidth = 51;
            this.dgvLoteProducto.Size = new System.Drawing.Size(508, 373);
            this.dgvLoteProducto.TabIndex = 15;
            this.dgvLoteProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoteProducto_CellClick);
            this.dgvLoteProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoteProducto_CellDoubleClick);
            this.dgvLoteProducto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoteProducto_CellEnter);
            // 
            // tbxIDmp
            // 
            this.tbxIDmp.Location = new System.Drawing.Point(142, 76);
            this.tbxIDmp.Name = "tbxIDmp";
            this.tbxIDmp.Size = new System.Drawing.Size(259, 22);
            this.tbxIDmp.TabIndex = 32;
            // 
            // Form_Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 411);
            this.Controls.Add(this.dgvLoteProducto);
            this.Controls.Add(this.dgvMateriaPrima);
            this.Controls.Add(this.gb_Lote);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Lote";
            this.Text = "Form_Lote";
            this.Load += new System.EventHandler(this.Form_Lote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).EndInit();
            this.gb_Lote.ResumeLayout(false);
            this.gb_Lote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoteProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriaPrima;
        private System.Windows.Forms.GroupBox gb_Lote;
        private System.Windows.Forms.ComboBox cBxProducto;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoCarne;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPesoCarne;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblIDmp;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox tBxTipoCarne;
        private System.Windows.Forms.RadioButton rBtnDerivado;
        private System.Windows.Forms.RadioButton rBtnCorte;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadCarne;
        private System.Windows.Forms.DataGridView dgvLoteProducto;
        private System.Windows.Forms.TextBox tbxIDmp;
    }
}