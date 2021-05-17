using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operaciones_Basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int n1 = 50;
                double n2 = Math.PI;
                int resta = n1 - Convert.ToInt32(n2);
                Console.WriteLine((resta).ToString());
                int res = n1 % Convert.ToInt32(n2);
                Console.WriteLine((res).ToString());
            
            }catch(Exception ex ){

            }
            Console.ReadKey();
        }
    }
}
