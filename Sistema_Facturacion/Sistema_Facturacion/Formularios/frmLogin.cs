using Sistema_Facturacion.Clases;
using Sistema_Facturacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcentar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario", "Error");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una claver", "Error");
            }

            if (!Datos.Validar_Usuario(txtUsuario.Text,txtClave.Text))
            {
                MessageBox.Show(Datos.Mensaje, "Error");
                txtUsuario.Focus();
                return;
            }


            Usuarios usuariologeado = Datos.GetUsuario(txtUsuario.Text);

            frmPrincipal miPrincipal = new frmPrincipal();
            this.Hide();
            miPrincipal.Usuariologiado = usuariologeado;
            miPrincipal.Show();
            

        }

       

        
    }
}
