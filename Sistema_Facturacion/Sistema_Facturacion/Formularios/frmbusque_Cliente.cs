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
    public partial class frmbusque_Cliente : Form
    {
        private string idCliente;

        public string IDCliente
        {
            get { return idCliente; }
        }
        public frmbusque_Cliente()
        {
            InitializeComponent();
        }

        private void frmbusque_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idCliente = "";
            this.Close();
        }

        private void btnAcentar_Click(object sender, EventArgs e)
        {
            //selectedRows filas selecionadas
            if (dgvBusqueda_cliente.SelectedRows.Count > 0)
            {
                idCliente = dgvBusqueda_cliente.SelectedRows[0].Cells[0].Value.ToString();

            }
            else
            {
                idCliente = dgvBusqueda_cliente.Rows[0].Cells[0].Value.ToString();
            }
            this.Close();
        }

        private void fillByIDClienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByIDCliente(this.facturacionDataSet.Cliente, iDClienteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNombresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByNombres(this.facturacionDataSet.Cliente, nombresToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByApellidosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillByApellidos(this.facturacionDataSet.Cliente, apellidosToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
        }
    }
}
