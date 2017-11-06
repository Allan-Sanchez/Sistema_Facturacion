using Sistema_Facturacion.Clases.DSFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    class Cliente
    {

        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();

        public static void NewCliente(string IDCliente, string Nombres, string Apellidos, string Direccion, 
                                      string Telefono, string Correo, string FechaNacimiento, int Cupo)
        {
            adaptador.NewCliente(IDCliente, Nombres, Apellidos, Direccion, Telefono, Correo, FechaNacimiento, Cupo);
        }

        public static void UpdateCliente(string Nombres,string Apellidos,string Direccion,string Telefono,string Correo,
                                         string FechaNacimiento,int Cupo,string IDCliente)
        {
            adaptador.UpdateCliente(Nombres, Apellidos, Direccion, Telefono, Correo, FechaNacimiento, Cupo, IDCliente);
        }

        public static void DeleteCliente(string IDCliente)
        {
            adaptador.DeleteCliente(IDCliente);
        }

        public static bool ExisteCliente(string IDCliente)
        {
            return adaptador.ExisteCliente(IDCliente) == 1;
        }
    }
}
