﻿using LibLlenarGrids;
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



        public frmConsulta_Articulos()
        {
            InitializeComponent();
        }

        private void frmConsulta_Articulos_Load(object sender, EventArgs e)
        {
            llenarGrids.SQL = ("SELECT dbo.Producto.IDProducto, dbo.Producto.Descripcion, dbo.Producto.Precio, dbo.Producto.Stock,"+
                " dbo.IVA.Descripcion AS IVA, dbo.Departamento.Descripcion AS Departamento, dbo.Producto.Notas"+
                " FROM dbo.Producto INNER JOIN dbo.IVA ON dbo.Producto.IDIVA = dbo.IVA.IDIVA INNER JOIN "+
                "dbo.Departamento ON dbo.Producto.IDDepartamento = dbo.Departamento.IDDepartamento");

            llenarGrids.LlenarGridWindows(dgvProductos);

        }
    }
}
