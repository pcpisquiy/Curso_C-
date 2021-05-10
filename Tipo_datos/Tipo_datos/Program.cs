using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tipo_datos
{
    class Program
    {
        #region  Variables numericas
            int n1=0;
            double dinero = 0.00;
            decimal Dinero = 0;
         #endregion
#region Variables booleanas
            bool bandera = true;
#endregion 

            #region variables de texto
         
            char letra = ' ';
            string Cadena = "";
            #endregion 

            static void Main(string[] args)
        {

          

            try 
            {
                Console.WriteLine();     
            
            }catch(Exception ex){
                Console.WriteLine("ERROR: "+ ex.Message);
            }
        }
    }
}
