using FrigoInca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using Menu = CapaPresentacion.Menu;

namespace FrigoInca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUsuario.Text;
            string password = txtPassword.Text;  

            bool areCredentialsValid = false;

            if (rbtnAdmin.Checked && username == "admin" && password == "admin")
            {
                areCredentialsValid = true;
            }
            else if (rbtnWrkr.Checked && username == "trabajador" && password == "trabajador")
            {
                areCredentialsValid = true;
            }

            if (areCredentialsValid)
            {
                this.Hide();
                Menu menuForm = new Menu(); 
                menuForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }


        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnWrkr_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
