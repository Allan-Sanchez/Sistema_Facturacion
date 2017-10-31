using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Facturacion.Clases
{
    class Utilidades
    {
        private static decimal numeroDecimal = 0;
        private static int numeroEntero = 0;
        private static string error = "";
        public static decimal NumeroDecimal
        {
            get { return Utilidades.numeroDecimal; }
        }


        public static int NumeroEntero
        {
            get { return Utilidades.numeroEntero; }
        }


        public static string Error
        {
            get { return Utilidades.error; }
        }


        public static bool ValidarDecimal(string num)
        {
            try
            {
                numeroDecimal = Convert.ToDecimal(num);
                error = "";
                return true;
            }
            catch (Exception ex)
            {
                numeroDecimal = 0;
                error = ex.Message;
                return false;
            }

        }

        public static bool ValidarEntero(string num)
        {
            try
            {
                numeroEntero = Convert.ToInt32(num);
                error = "";
                return true;
            }
            catch (Exception ex)
            {
                numeroEntero = 0;
                error = ex.Message;
                return false;
            }

        }



    }
}
