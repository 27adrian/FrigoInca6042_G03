namespace FrigoInca
{
    partial class MantenedorLotes
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
            this.gb_Lote = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KgCarne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Lote.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(598, 215);
            this.dataGridView1.TabIndex = 14;
            // 
            // gb_Lote
            // 
            this.gb_Lote.Controls.Add(this.textBox1);
            this.gb_Lote.Controls.Add(this.label5);
            this.gb_Lote.Controls.Add(this.comboBox1);
            this.gb_Lote.Controls.Add(this.label2);
            this.gb_Lote.Controls.Add(this.dateTimePicker1);
            this.gb_Lote.Controls.Add(this.label1);
            this.gb_Lote.Controls.Add(this.cbxTipoProducto);
            this.gb_Lote.Controls.Add(this.btn_Eliminar);
            this.gb_Lote.Controls.Add(this.btn_Modificar);
            this.gb_Lote.Controls.Add(this.btn_Agregar);
            this.gb_Lote.Controls.Add(this.label4);
            this.gb_Lote.Controls.Add(this.lblTipoCliente);
            this.gb_Lote.Controls.Add(this.label3);
            this.gb_Lote.Controls.Add(this.txt_KgCarne);
            this.gb_Lote.Location = new System.Drawing.Point(29, 30);
            this.gb_Lote.Name = "gb_Lote";
            this.gb_Lote.Size = new System.Drawing.Size(598, 224);
            this.gb_Lote.TabIndex = 13;
            this.gb_Lote.TabStop = false;
            this.gb_Lote.Text = "Informacion lote";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kg";
            // 
            // cbxTipoProducto
            // 
            this.cbxTipoProducto.Items.AddRange(new object[] {
            "Res",
            "Cerdo",
            "Pollo"});
            this.cbxTipoProducto.Location = new System.Drawing.Point(179, 147);
            this.cbxTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoProducto.Name = "cbxTipoProducto";
            this.cbxTipoProducto.Size = new System.Drawing.Size(199, 21);
            this.cbxTipoProducto.TabIndex = 15;
            this.cbxTipoProducto.Text = "--Seleccionar tipo de Producto--";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(450, 159);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(125, 49);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Deshabilitar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(450, 97);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 44);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(450, 30);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(125, 49);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(19, 77);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(76, 13);
            this.lblTipoCliente.TabIndex = 1;
            this.lblTipoCliente.Text = "Tipo de carne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso:";
            // 
            // txt_KgCarne
            // 
            this.txt_KgCarne.Location = new System.Drawing.Point(202, 121);
            this.txt_KgCarne.Name = "txt_KgCarne";
            this.txt_KgCarne.Size = new System.Drawing.Size(75, 20);
            this.txt_KgCarne.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "IDMateria Prima";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Res",
            "Cerdo",
            "Pollo"});
            this.comboBox1.Location = new System.Drawing.Point(179, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "--Seleccionar tipo de MP--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 27;
            // 
            // MantenedorLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Lote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantenedorLotes";
            this.Text = "RegistrarLotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Lote.ResumeLayout(false);
            this.gb_Lote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Lote;
        private System.Windows.Forms.ComboBox cbxTipoProducto;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KgCarne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}