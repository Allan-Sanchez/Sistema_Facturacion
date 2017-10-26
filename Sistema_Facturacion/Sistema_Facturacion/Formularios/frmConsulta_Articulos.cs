using LibLlenarCombos;
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
    public partial class frmConsulta_Articulos : Form
    {

        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");




        public frmConsulta_Articulos()
        {
            InitializeComponent();
        }

        private void frmConsulta_Articulos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
                " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
                " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento");

            llenarGrids.LlenarGridWindows(dgvProductos);

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
                                "SELECT '','[Todos]' "+
                                "ORDER BY 2";

            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbIva);






        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            // selectdIndex = al que esta seleccionado
            if (cmbDepartamento.SelectedIndex==0)
            {
                llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
               " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
               " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
               "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento");
      
            }
            else
            {
                llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
              " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
              " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
              "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento "+
              "WHERE dbo.Producto.IDDepartamento =" + cmbDepartamento.SelectedValue);


            }
            llenarGrids.LlenarGridWindows(dgvProductos);
        }

        private void cmbIva_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selectdIndex = al que esta seleccionado
            if (cmbIva.SelectedIndex == 0)
            {
                llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
               " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
               " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
               "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento");

            }
            else
            {
                llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
              " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
              " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN " +
              "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento " +
              "WHERE dbo.Producto.IDIVA =" + cmbIva.SelectedValue);
                
                //Selected.Values = valor del que esta selecccionado

            }
            llenarGrids.LlenarGridWindows(dgvProductos);
        }
    }
}
