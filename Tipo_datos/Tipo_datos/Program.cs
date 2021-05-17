using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tipo_datos
{
    class Program
    {
        #region  Variables numericas
        static int n1 = 300;
        static int n2 = 6900;
        static double dinero = 5.201184784;
        static decimal Dinero = 20;
        #endregion
        #region Variables booleanas
        static bool bandera = true;
        #endregion
        #region variables de texto
        static char letra = 's';
        static string Cadena = "hgfdssdfdf dfgdsfgdsfg ?";
        static string salto = "\n";
        #endregion

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Int: " +(n1).ToString()+" "+n2.ToString()+salto+"Double: "+dinero.ToString()+" " + Dinero.ToString()+salto+"STRING: "+letra.ToString()+" "+Cadena.ToString());
              

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
