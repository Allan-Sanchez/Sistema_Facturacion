using LibLlenarGrids;
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
    public partial class frmBusqueda_Productos : Form
    {
        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
        private int idproducto;

        public int IDProducto
        {
            get { return idproducto; }
        }

        public frmBusqueda_Productos()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Productos_Load(object sender, EventArgs e)
        {
            txtFiltro_Busqueda.Focus();

            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, " +
                " dbo.Departamento.Descripcion AS Departamento " +
                " FROM dbo.Departamento INNER JOIN " +
                " dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                " ORDER BY dbo.Producto.IDProducto");

            llenarGrids.LlenarGridWindows(dgvBusqueda);
        }

        private void txtFiltro_Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbtnIdproducto.Checked)//si esta seleccionado rbtnIdproducto
            {
                int num;
                try
                {
                    num = Convert.ToInt32(txtFiltro_Busqueda.Text);
                }
                catch (Exception)
                {

                    num = 0;
                }

                llenarGrids.SQL = (" SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, " +
               " dbo.Departamento.Descripcion AS Departamento " +
               " FROM dbo.Departamento INNER JOIN " +
               " dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
               " WHERE dbo.Producto.IDProducto  >= " + num + " " +
               " ORDER BY dbo.Producto.IDProducto");

            }
            else
            {
                llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, " +
                " dbo.Departamento.Descripcion AS Departamento " +
                " FROM dbo.Departamento INNER JOIN " +
                " dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                "  WHERE  dbo.Producto.Descripcion LIKE '" + txtFiltro_Busqueda.Text + "%'" +
                " ORDER BY dbo.Producto.IDProducto");

            }
            llenarGrids.LlenarGridWindows(dgvBusqueda);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idproducto = 0;
            this.Close();

          
        }

        private void rbtnIdproducto_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro_Busqueda.Text = "";

            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, " +
                " dbo.Departamento.Descripcion AS Departamento " +
                " FROM dbo.Departamento INNER JOIN " +
                " dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                " ORDER BY dbo.Producto.IDProducto");

            llenarGrids.LlenarGridWindows(dgvBusqueda);

        }

        private void rbtnDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltro_Busqueda.Text = "";

            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, " +
                " dbo.Departamento.Descripcion AS Departamento " +
                " FROM dbo.Departamento INNER JOIN " +
                " dbo.Producto ON dbo.Departamento.IDDepartamento = dbo.Producto.IDDepartamento " +
                " ORDER BY dbo.Producto.Descripcion");

            llenarGrids.LlenarGridWindows(dgvBusqueda);

        }

        private void btnAcentar_Click(object sender, EventArgs e)
        {
            //selectedRows filas selecionadas
            if (dgvBusqueda.SelectedRows.Count > 0)
            {
                idproducto = Convert.ToInt32(dgvBusqueda.SelectedRows[0].Cells[0].Value);

            }
            else
            {
                idproducto = Convert.ToInt32(dgvBusqueda.Rows[0].Cells[0].Value);
            }
            this.Close();
        }


    }
}
