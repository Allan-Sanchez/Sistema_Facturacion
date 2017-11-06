using Sistema_Facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Facturacion.Formularios
{
    public partial class frmPrincipal : Form
    {

        private Usuarios usuariologiado;

        internal Usuarios Usuariologiado
        {
            get { return usuariologiado; }
            set { usuariologiado = value; }
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta_Articulos miConsulta_Articulos = new frmConsulta_Articulos();

            miConsulta_Articulos.MdiParent = this; // MdiParent = quien es el padre de el formulario this= pfrmPrincipal
            miConsulta_Articulos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulos miArticulos = new FrmArticulos();
           
            miArticulos.MdiParent = this; // MdiParent = quien es el padre de el formulario this= pfrmPrincipal
            miArticulos.Usuariologiado = this.usuariologiado;
            miArticulos.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tssUsuario.Text = usuariologiado.Nombres + " "  + usuariologiado.Apellidos;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmClientes miCliente = new frmClientes();

            miCliente.MdiParent = this;
            miCliente.Usuariologiado = this.usuariologiado;
            miCliente.Show();
        }

       

        

       
        
    }
}
