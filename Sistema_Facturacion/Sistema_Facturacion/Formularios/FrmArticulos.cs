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
    public partial class FrmArticulos : Form
    {

        LlenarGrids llenarGrids = new LlenarGrids("Parametros.xml");
        LlenarCombos llenarCombos = new LlenarCombos("Parametros.xml");


        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock," +
                " dbo.Producto.IDIVA,dbo.IVA.Descripcion AS IVA, dbo.Producto.IDDepartamento, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas" +
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
                                "SELECT '','[Todos]' " +
                                "ORDER BY 2";

            llenarCombos.CampoID = "IDIVA";
            llenarCombos.CampoTexto = "Descripcion";
            llenarCombos.LlenarComboWindows(cmbIva);

        }

       

        

       

        
    }
}
