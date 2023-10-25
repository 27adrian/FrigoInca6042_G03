namespace FrigoInca
{
    partial class Login
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
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPsswrd = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnWrkr = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.Location = new System.Drawing.Point(126, 171);
            this.tbxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(127, 23);
            this.tbxUsuario.TabIndex = 1;
            this.tbxUsuario.TextChanged += new System.EventHandler(this.tbxUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(64, 174);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(76, 105);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(177, 31);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // lblPsswrd
            // 
            this.lblPsswrd.AllowDrop = true;
            this.lblPsswrd.AutoSize = true;
            this.lblPsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsswrd.Location = new System.Drawing.Point(46, 211);
            this.lblPsswrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPsswrd.Name = "lblPsswrd";
            this.lblPsswrd.Size = new System.Drawing.Size(85, 17);
            this.lblPsswrd.TabIndex = 5;
            this.lblPsswrd.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(126, 209);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(127, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(74, 255);
            this.rbtnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(88, 17);
            this.rbtnAdmin.TabIndex = 6;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Administrador";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // rbtnWrkr
            // 
            this.rbtnWrkr.AutoSize = true;
            this.rbtnWrkr.Location = new System.Drawing.Point(162, 255);
            this.rbtnWrkr.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnWrkr.Name = "rbtnWrkr";
            this.rbtnWrkr.Size = new System.Drawing.Size(76, 17);
            this.rbtnWrkr.TabIndex = 7;
            this.rbtnWrkr.TabStop = true;
            this.rbtnWrkr.Text = "Trabajador";
            this.rbtnWrkr.UseVisualStyleBackColor = true;
            this.rbtnWrkr.CheckedChanged += new System.EventHandler(this.rbtnWrkr_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(104, 305);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 38);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrigoInca.Properties.Resources.Frigoinca_LogoBueno1;
            this.pictureBox1.Location = new System.Drawing.Point(82, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbtnWrkr);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.lblPsswrd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbxUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPsswrd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.RadioButton rbtnWrkr;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}