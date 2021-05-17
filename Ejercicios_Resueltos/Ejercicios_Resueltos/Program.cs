using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Resueltos
{
    class Program
    {
        static void Main(string[] args)
        {

            //try {
            //    Console.WriteLine("Ingrese un número");
            //    int cantidad = int.Parse(Console.ReadLine());
            //    int positivos = 0, negativos = 0, pares = 0, impares = 0, ceros = 0;
            //    for (int x = 1; x <= cantidad; x++) {
            //        Console.WriteLine("Ingrese un número "+x.ToString());
            //        int Numero = int.Parse(Console.ReadLine());
            //        if (Numero < 0)
            //        {
            //            negativos++;
            //        }
            //        else if (Numero > 0)
            //        {
            //            positivos++;
            //        }
            //        else {
            //            ceros++;
            //        }
            //        if ((Numero % 2) == 0)
            //        {
            //            pares++;
            //        }
            //        else {
            //            impares++;
            //        }
            //        if (ceros > 0) {
            //            pares -= ceros; 
            //        }
            //    }
            //    Console.WriteLine("Total Número pares: "+pares.ToString());
            //    Console.WriteLine("Total Número impares: " + impares.ToString());
            //    Console.WriteLine("Total Número ceros: " + ceros.ToString());
            //    Console.WriteLine("Total Número Negativos: " + negativos.ToString());
            //    Console.WriteLine("Total Número postivos: " + positivos.ToString());
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            try {
                Notas notas = new Notas();
                Console.WriteLine("Ingrese el nombre del alumno");
                string nombre = Console.ReadLine().ToString();
                Console.WriteLine("Ingrese el nombre del curso");
                string nombre_curso = Console.ReadLine().ToString();
                Console.WriteLine("Ingrse la nota");
                double nota = double.Parse(Console.ReadLine().ToString());
                notas.Solicitar_Datos(nombre, nota, nombre_curso);
                Console.WriteLine(notas.Mostrar_Datos().ToString());
                Console.WriteLine();


            } catch(Exception ex){ Console.WriteLine("Error. {ex}.",ex); }
            Console.ReadKey();
        }
    }
}
