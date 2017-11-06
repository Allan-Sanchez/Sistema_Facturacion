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
    public partial class frmClientes : Form
    {
        public bool nuevo = false;
        private int posicion;
        private Usuarios usuariologiado;

        internal Usuarios Usuariologiado
        {
            get { return usuariologiado; }
            set { usuariologiado = value; }
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.facturacionDataSet);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
            EstableserPermisos();

        }
        private void EstableserPermisos()
        {
            if (usuariologiado.IDPerfil != 1)
            {
                tsbGuardar.Enabled = false;
                tsbEditar.Enabled = false;
                tsbEliminar.Enabled = false;
                tsbNuevo.Enabled = false;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            iDClienteTextBox.Enabled = true;
            LimpiarCampos();
            HabilitarCampos();
            iDClienteTextBox.Focus();
        }

        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;

            tsbNuevo.Enabled = false;
            tsbEditar.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbBuscar.Enabled = false;



            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            correoTextBox.Enabled = true;
            fechaNacimientoDateTimePicker.Enabled = true;
            telefonoTextBox.Enabled = true;
            cupoTextBox.Enabled = true;

        }

        private void LimpiarCampos()
        {
            iDClienteTextBox.Text = "";
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            direccionTextBox.Text = "";
            correoTextBox.Text = "";
            fechaNacimientoDateTimePicker.Text = "";
            telefonoTextBox.Text = "";
            cupoTextBox.Text = "";

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            //posicion actual
            posicion = clienteBindingSource.Position;
            HabilitarCampos();
            nombresTextBox.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarFormularios();
        }

        private void ActualizarFormularios()
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);
        }

        private void DesabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;

            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = true;
            tsbBuscar.Enabled = true;


            iDClienteTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            correoTextBox.Enabled = false;
            fechaNacimientoDateTimePicker.Enabled = false;
            telefonoTextBox.Enabled = false;
            cupoTextBox.Enabled = false;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            if (nuevo)
            {
                Cliente.NewCliente(iDClienteTextBox.Text, 
                    nombresTextBox.Text, 
                    apellidosTextBox.Text, 
                    direccionTextBox.Text, 
                    telefonoTextBox.Text, 
                    correoTextBox.Text, 
                    fechaNacimientoDateTimePicker.Text,
                    Convert.ToInt32(cupoTextBox.Text));
            }
            else
            {
                Cliente.UpdateCliente(nombresTextBox.Text, 
                    apellidosTextBox.Text, 
                    direccionTextBox.Text,
                    telefonoTextBox.Text, 
                    correoTextBox.Text, 
                    fechaNacimientoDateTimePicker.Text, 
                    Convert.ToInt32(cupoTextBox.Text), 
                    iDClienteTextBox.Text);
            }
            MessageBox.Show("Cambios realizados con exito", "Confirmacion");
            DesabilitarCampos();
            ActualizarFormularios();
            if (!nuevo)
            {
                clienteBindingSource.Position = posicion;
            }
        }

        private bool Validar()
        {
            if (iDClienteTextBox.Text == "")
            {
                MessageBox.Show("Debe Ingresar un id cliente", "Error");
                iDClienteTextBox.Focus();
                return false;
            }

            if (nuevo && Cliente.ExisteCliente(iDClienteTextBox.Text))
            {
                MessageBox.Show("Ya existe un cliente con es ID", "Error");
                iDClienteTextBox.Text = "";
                iDClienteTextBox.Focus();
                return false;
            }

            if (nombresTextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar nombres", "Error");
                nombresTextBox.Focus();
                return false;
            }

            if (apellidosTextBox.Text == "")
            {
                MessageBox.Show("Debe Ingresar apellidos", "Error");
                apellidosTextBox.Focus();
                return false;
            }

            if (!Utilidades.ValidarDecimal(cupoTextBox.Text))
            {

                MessageBox.Show(Utilidades.Error, "Error");
                cupoTextBox.Text = "";
                cupoTextBox.Focus();
                return false;

            }
            if (Utilidades.NumeroDecimal < 0)
            {
                MessageBox.Show("Debe ingresar un Valor positivo", "Error");
                cupoTextBox.Focus();
                return false;
            }

            return true;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //Dialogo respuesta de nuestro mensaje

            DialogResult rta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;
            Cliente.DeleteCliente(iDClienteTextBox.Text);
            
            MessageBox.Show("Cliente Borrado correctamente", "Confirmacion");
            ActualizarFormularios();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmbusque_Cliente miBusqueda = new frmbusque_Cliente();
            miBusqueda.ShowDialog();

            if (miBusqueda.IDCliente == "") return;
            clienteBindingSource.Position = clienteBindingSource.Find("IDCliente", miBusqueda.IDCliente);
           
        }
    }
}
