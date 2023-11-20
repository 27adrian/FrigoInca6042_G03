using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrigoInca
{
    public partial class Mantenedor_Ubigeo : Form
    {
        public Mantenedor_Ubigeo()
        {
            InitializeComponent();
            Listarcliente();

        }

        private void Mantenedor_Ubigeo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entUbigeo c = new entUbigeo();
                c.Pais = txtPais.Text.Trim();
                c.Departamento = txtDepartamento.Text.Trim();
                c.Provincia = txtProvincia.Text.Trim();
                c.Distrito = txtDistrito.Text.Trim();

                logUbigeo.Instancia.InsertarUbigeo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            Listarcliente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }
        public void Listarcliente()
        {
            dgvUbigeo.DataSource = logUbigeo.Instancia.ListarUbigeo();
        }
    }
}
