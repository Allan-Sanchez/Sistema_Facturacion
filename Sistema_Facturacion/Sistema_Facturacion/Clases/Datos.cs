using LibConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    class Datos
    {

        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");



        public static string Mensaje { get { return mensaje; } }

        public static bool Validar_Usuario(string usuario, string clave)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            conexion.SQL = "SELECT (1) FROM Usuario WHERE Usuario= '" + usuario +
                "' AND Clave='" + clave + "'";

            if (!conexion.ConsultarValorUnico(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            if (conexion.ValorUnico == null)
            {
                mensaje = "Usuario o Contraseña no valida ";
                conexion.CerrarConexion();
                return false;
            }

            conexion.CerrarConexion();
            return true;

        }

        internal static bool NewProducto(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "INSERT INTO	Producto (Descripcion,Precio,Stock,Notas,IDIVA,IDDepartamento)"+
                " VALUES ('"+producto.Descripcion+"',"+producto.Precio+","+producto.Stock+",'"+producto.Notas+
                "',"+producto.IDIVA+","+producto.IDDepartamento+")";

            if (!conexion.EjecutarSentencia(false))//falso por que estamos mandando la sentencia es por un querry
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "producto Ingresado correctamente";
            conexion.CerrarConexion();
            return true;
        }

        internal static bool UpdateProducto(Producto producto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL = "UPDATE Producto SET Descripcion = '"+producto.Descripcion+"', Precio = "+producto.Precio+",Stock = "+producto.Stock
                +", Notas = '"+producto.Notas+"',IDIVA = "+producto.IDIVA+", IDDepartamento = "+producto.IDDepartamento+"  WHERE IDProducto = " + producto.IDProducto;

            if (!conexion.EjecutarSentencia(false))//falso por que estamos mandando la sentencia es por un querry
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "producto actualizado correctamente";
            conexion.CerrarConexion();
            return true;
        }

        internal static bool DeleteProducto(int idproducto)
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }
            conexion.SQL ="DELETE FROM Producto WHERE IDProducto ="+idproducto;

            if (!conexion.EjecutarSentencia(false))//falso por que estamos mandando la sentencia es por un querry
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            mensaje = "producto eliminado correctamente";
            conexion.CerrarConexion();
            return true;
        }
    }
}
