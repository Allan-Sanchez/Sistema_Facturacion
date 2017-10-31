using LibLlenarCombos;
using LibLlenarGrids;
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
    public partial class FrmArticulos : Form
    {

        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");
        private int i = 0;
        private bool nuevo;


        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {

            Met_llenarGrids();
            Met_llenarCombos();
            Met_llenarCampos();

        }

        private void Met_llenarCampos()
        {
            //Row contiene el numero de filas count Contador
            if (dgvProductos.Rows.Count == 0) return;
            if (dgvProductos.Rows[i].Cells["IDProducto"].Value == null) return;//estamos en el ultimo registro
            txtIdProducto.Text = dgvProductos.Rows[i].Cells["IDProducto"].Value.ToString();//de vuelve un object por eso lo castiamos a un string
            txtDescripcion.Text = dgvProductos.Rows[i].Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[i].Cells["Precio"].Value.ToString();
            txtStock.Text = dgvProductos.Rows[i].Cells["Stock"].Value.ToString();
            cmbDepartamento.SelectedValue = dgvProductos.Rows[i].Cells["IDDepartamento"].Value.ToString();
            cmbIva.SelectedValue = dgvProductos.Rows[i].Cells["IDIVA"].Value.ToString();
            txtNotas.Text = dgvProductos.Rows[i].Cells["Notas"].Value.ToString();
            //selectedValue es para colocar en el combo box el dato que nosotros queremos



        }

        private void Met_llenarCombos()
        {
            //a la hora de escribir la funcion SQL antes de concatenar con + se deja un espacion ejemplo "Descripcion-"+marque el espacio con(-)
            llenarCombos.SQL = "SELECT IDDepartamento, Descripcion " +
                                "FROM Departamento " +
                                "UNION " +
                                "SELECT '','[Todos]' " +
                                "ORDER BY 2";

            llenarCombos.CampoID = "IDDepartamento";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbDepartamento);

            llenarCombos.SQL = "SELECT IDIVA, Descripcion " +
                                "FROM IVA " +
                                "UNION " +
                                "SELECT '','[Todos]' " +
                                "ORDER BY 2";

            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbIva);
        }

        private void Met_llenarGrids()
        {
            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
                " dbo.Producto.IDIVA,dbo.IVA.Descripcion AS IVA, dbo.Producto.IDDepartamento, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
                " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento");

            llenarGrids.LlenarGridWindows(dgvProductos);

        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i++;

            if (i == dgvProductos.Rows.Count)
            {
                i--;
                return;
            }

            Met_llenarCampos();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i--;

            if (i == -1)
            {
                i = 0;
                return;
            }
            Met_llenarCampos();
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i = 0;
            Met_llenarCampos();

        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0) return;
            i = dgvProductos.Rows.Count - 2;
            Met_llenarCampos();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
            txtDescripcion.Focus();
        }

        private void HabilitarCampos()
        {
            tsbPrimero.Enabled = false;
            tsbAnterior.Enabled = false;
            tsbSiguiente.Enabled = false;
            tsbUltimo.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbEditar.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = false;
            tsbBuscar.Enabled = false;


            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            cmbDepartamento.Enabled = true;
            cmbIva.Enabled = true;
            txtNotas.Enabled = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            Met_llenarCampos();
        }

        private void DeshabilitarCampos()
        {
            tsbPrimero.Enabled = true;
            tsbAnterior.Enabled = true;
            tsbSiguiente.Enabled = true;
            tsbUltimo.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = true;
            tsbBuscar.Enabled = true;


            txtDescripcion.Enabled = false ;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            cmbDepartamento.Enabled = false;
            cmbIva.Enabled = false;
            txtNotas.Enabled = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos();
            txtDescripcion.Focus();
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cmbDepartamento.SelectedIndex = 0;//selectdintex le pasamos cero para que nos miestre el primero de nuestro catalogo
            cmbIva.SelectedIndex = 0;
            txtNotas.Text = "";
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Producto producto = new Producto();
            try
            {
                producto.IDProducto = Convert.ToInt32(txtIdProducto.Text);
            }
            catch (Exception)
            {

                producto.IDProducto = 0;
            }
          
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.Notas = txtNotas.Text;
            producto.IDDepartamento = Convert.ToInt32(cmbDepartamento.SelectedValue);
            producto.IDIVA = Convert.ToInt32(cmbIva.SelectedValue);

            if (nuevo)
            {
                if (!Datos.NewProducto(producto))
                {
                    MessageBox.Show(Datos.Mensaje, "Errror");
                    return;
                }
            }
            else
            {

                if (!Datos.UpdateProducto(producto))
                {
                    MessageBox.Show(Datos.Mensaje, "Errror");
                    return;
                }
            }
            MessageBox.Show(Datos.Mensaje,"Confirmacion");
            Met_llenarGrids();
            DeshabilitarCampos();

            if (nuevo) tsbUltimo_Click(sender, e);
            else Met_llenarCombos();
            
            
        }



        private bool ValidarCampos() 
        {
            if (txtDescripcion.Text=="")
            {
                MessageBox.Show("Debe Ingresar una Descripcion","Error");
                txtDescripcion.Focus();
                return false;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Precio", "Error");
                txtPrecio.Focus();
                return false;
            }

            if (!Utilidades.ValidarDecimal(txtPrecio.Text)) 
            {

                MessageBox.Show(Utilidades.Error,"Error");
                txtPrecio.Text = "";
                txtPrecio.Focus();
                return false;
            
            }
            if (Utilidades.NumeroDecimal<0)
            {
                MessageBox.Show("Debe ingresar un Valor positivo","Error");
                txtPrecio.Focus();
                return false;
            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Stock", "Error");
                txtStock.Focus();
                return false;
            }

            if (!Utilidades.ValidarEntero(txtStock.Text))
            {

                MessageBox.Show(Utilidades.Error, "Error");
                txtStock.Text = "";
                txtStock.Focus();
                return false;

            }
            if (Utilidades.NumeroEntero < 0)
            {
                MessageBox.Show("Debe ingresar un Valor positivo", "Error");
                txtStock.Focus();
                return false;
            }
            if (cmbDepartamento.SelectedIndex==0)
            {
                MessageBox.Show("Debe Seleccionar un departamento", "Error");
                cmbDepartamento.Focus();
                return false;
            }
            if (cmbIva.SelectedIndex == 0)
            {
                MessageBox.Show("Debe Seleccionar un Iva", "Error");
                cmbIva.Focus();
                return false;
            }

             return true;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //Dialogo respuesta de nuestro mensaje

            DialogResult rta = MessageBox.Show("Estaa seguro de borrar el registro actual?", 
                "Confirmacion", MessageBoxButtons.YesNo);

            if (rta == DialogResult.No) return;

            if (!Datos.DeleteProducto(Convert.ToInt32(txtIdProducto.Text))) 
            {
                MessageBox.Show(Datos.Mensaje,"Error");
                return;
            
            }
            MessageBox.Show(Datos.Mensaje,"Confirmacion");
            Met_llenarGrids();
            Met_llenarCampos();
            tsbPrimero_Click(sender, e);
            
            
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda_Productos miBusqueda = new frmBusqueda_Productos();
            miBusqueda.ShowDialog();

            for (i = 0; i < dgvProductos.Rows.Count; i++)
            {
                if (miBusqueda.IDProducto ==Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value)) break;
                
            }
            Met_llenarCampos();
        }






    }
}
