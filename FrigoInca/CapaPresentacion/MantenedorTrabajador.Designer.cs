namespace FrigoInca
{
    partial class MantenedorTrabajador
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
            this.gb_Trabajador = new System.Windows.Forms.GroupBox();
            this.cbxTipoTrabajador = new System.Windows.Forms.ComboBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_DNI = new System.Windows.Forms.TextBox();
            this.lblTipoTrabajador = new System.Windows.Forms.Label();
            this.txt_Telefono_contacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_N_trabajador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Trabajador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 345);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 265);
            this.dataGridView1.TabIndex = 14;
            // 
            // gb_Trabajador
            // 
            this.gb_Trabajador.Controls.Add(this.cbxTipoTrabajador);
            this.gb_Trabajador.Controls.Add(this.btn_Eliminar);
            this.gb_Trabajador.Controls.Add(this.btn_Modificar);
            this.gb_Trabajador.Controls.Add(this.btn_Agregar);
            this.gb_Trabajador.Controls.Add(this.label4);
            this.gb_Trabajador.Controls.Add(this.txt_Correo);
            this.gb_Trabajador.Controls.Add(this.txt_DNI);
            this.gb_Trabajador.Controls.Add(this.lblTipoTrabajador);
            this.gb_Trabajador.Controls.Add(this.txt_Telefono_contacto);
            this.gb_Trabajador.Controls.Add(this.label3);
            this.gb_Trabajador.Controls.Add(this.txt_N_trabajador);
            this.gb_Trabajador.Controls.Add(this.label5);
            this.gb_Trabajador.Controls.Add(this.label6);
            this.gb_Trabajador.Location = new System.Drawing.Point(41, 31);
            this.gb_Trabajador.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Trabajador.Name = "gb_Trabajador";
            this.gb_Trabajador.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Trabajador.Size = new System.Drawing.Size(797, 276);
            this.gb_Trabajador.TabIndex = 13;
            this.gb_Trabajador.TabStop = false;
            this.gb_Trabajador.Text = "Informacion Trabajador";
            // 
            // cbxTipoTrabajador
            // 
            this.cbxTipoTrabajador.Items.AddRange(new object[] {
            "Trabajador",
            "Administrador"});
            this.cbxTipoTrabajador.Location = new System.Drawing.Point(240, 56);
            this.cbxTipoTrabajador.Name = "cbxTipoTrabajador";
            this.cbxTipoTrabajador.Size = new System.Drawing.Size(264, 24);
            this.cbxTipoTrabajador.TabIndex = 15;
            this.cbxTipoTrabajador.Text = "--Seleccionar tipo de trabajador--";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(600, 196);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(167, 60);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(600, 119);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(167, 54);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(600, 37);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(167, 60);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° de DNI:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(240, 171);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(264, 22);
            this.txt_Correo.TabIndex = 10;
            // 
            // txt_DNI
            // 
            this.txt_DNI.Location = new System.Drawing.Point(240, 136);
            this.txt_DNI.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DNI.Name = "txt_DNI";
            this.txt_DNI.Size = new System.Drawing.Size(264, 22);
            this.txt_DNI.TabIndex = 9;
            // 
            // lblTipoTrabajador
            // 
            this.lblTipoTrabajador.AutoSize = true;
            this.lblTipoTrabajador.Location = new System.Drawing.Point(26, 59);
            this.lblTipoTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTrabajador.Name = "lblTipoTrabajador";
            this.lblTipoTrabajador.Size = new System.Drawing.Size(128, 16);
            this.lblTipoTrabajador.TabIndex = 1;
            this.lblTipoTrabajador.Text = "Tipo de Trabajador:";
            // 
            // txt_Telefono_contacto
            // 
            this.txt_Telefono_contacto.Location = new System.Drawing.Point(240, 209);
            this.txt_Telefono_contacto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono_contacto.Name = "txt_Telefono_contacto";
            this.txt_Telefono_contacto.Size = new System.Drawing.Size(264, 22);
            this.txt_Telefono_contacto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo:";
            // 
            // txt_N_trabajador
            // 
            this.txt_N_trabajador.Location = new System.Drawing.Point(240, 97);
            this.txt_N_trabajador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_N_trabajador.Name = "txt_N_trabajador";
            this.txt_N_trabajador.Size = new System.Drawing.Size(264, 22);
            this.txt_N_trabajador.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono de contacto:";
            // 
            // MantenedorTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_Trabajador);
            this.Name = "MantenedorTrabajador";
            this.Text = "MantenedorTrabajador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Trabajador.ResumeLayout(false);
            this.gb_Trabajador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Trabajador;
        private System.Windows.Forms.ComboBox cbxTipoTrabajador;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_DNI;
        private System.Windows.Forms.Label lblTipoTrabajador;
        private System.Windows.Forms.TextBox txt_Telefono_contacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_N_trabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}