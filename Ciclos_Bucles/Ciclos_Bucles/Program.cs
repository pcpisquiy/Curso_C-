using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciclos_Bucles
{
    //for (Variable inicializadora= inicio; limite; paso ++= aumenta 1| -- disminuye 1| +=x aumenta el valor de x | -=x disminuye el valor de x |)
    //while (<condicion>)
    // do{} while(<condicion>)
    //for each()
    class Program
    {
        static void Main(string[] args)
        {
            ////Tablas de multiplicar
            //for (int multiplicador = 1; multiplicador <= 40;multiplicador++)
            //{
            //    Console.WriteLine("\nTabla Número: "+multiplicador.ToString());
            //    for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
            //    {

            //        Console.WriteLine(multiplicador.ToString() + "*" + multiplicando.ToString() + "=" + (multiplicador * multiplicando).ToString());
            //    }
            //}

            //numeros perfectos
            //try {
            //    Console.WriteLine("Ingrese un número");
            //    int numero = int.Parse(Console.ReadLine());
            //    int perfecto = 0;
            //    if(numero>0){
            //        for (int x = 1; x < numero; x++) { 
            //            if((numero%x)==0){
            //                //perfecto+=x;
            //                perfecto = perfecto + x;
            //            }
            //        }

            //    }
            //    if (perfecto == numero)
            //    {
            //        Console.WriteLine("Es numero perfecto");
            //    }
            //    else {
            //        Console.WriteLine("No es numero perfecto");
            //    }
            //}
            //catch (Exception ex) { 
            //Console.WriteLine(ex.Message);
            //}
            try
            {
                Console.WriteLine("Ingrese el numero de niveles");
                int niveles = int.Parse(Console.ReadLine());
                string ast = "";
                string blank = "";
                for (int x = 1; x <= niveles; x++)
                {
                    ast += "*";
                    for (int y = 1; y <= x; y++) {
                        blank += " ";
                        string cadena = blank + ast;
                        Console.WriteLine(cadena.ToString());
                    
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //secuencia fibonacci

            //try
            //{
            //    Console.WriteLine("Ingrese un número");
            //    int numero = int.Parse(Console.ReadLine());
            //    int contador = 0;
            //    int a = 0;
            //    int b = 1;
            //    int temporal = 0;
            //    Console.Write("0" + " ");
            //    do
            //    {
            //        temporal = a;
            //        a = b;
            //        b = temporal + a;
            //        Console.Write(a.ToString() + " ");
            //        contador++;
            //    } while (contador < numero);

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            // Primo no primo
            //try
            //{
            //    Console.WriteLine("Ingrese un número");
            //    int numero = int.Parse(Console.ReadLine());
            //    int contador = 1;
            //    int cantidad_divisores=0;
            //    do {
            //        if ((numero % contador) == 0) {
            //            cantidad_divisores++;
            //        }
            //        contador++;
            //    } while (contador <= numero);
            //    if (cantidad_divisores > 2 || numero!=1)
            //    {
            //        Console.WriteLine("Es primo");
            //    }
            //    else {
            //        Console.WriteLine("No es primo");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //validador
            //try {
            //    Console.WriteLine("Ingese el nombre del alumno");
            //    string nombre = Console.ReadLine();
            //    Console.WriteLine("Ingese el Sexo del alumno M/F");
            //    string sexo = Console.ReadLine();
            //    Console.WriteLine("Ingese la nota del alumno del alumno");
            //    double Promedio = Convert.ToDouble(Console.ReadLine());
            //    string Tipo_alumno = "";
            //    Console.Clear();
            //    bool Bandera = true;
            //    while (Bandera) {
            //        switch (sexo.ToUpper())
            //        {
            //            case "M":
            //                sexo = "MASCULINO";
            //                break;
            //            case "F":
            //                sexo = "FEMENINO";
            //            break;
            //            default:
            //                Console.Clear();
            //                Console.WriteLine("Sexo invalido");
            //                Bandera=false;
            //                break;
            //            break;

            //        }
            //        if (Promedio < 60)
            //        {
            //            Tipo_alumno = "Malo";
            //            break;

            //        }
            //        else if (Promedio >= 60 && Promedio <= 70)
            //        {
            //            Tipo_alumno = "Regular";
            //            break;
            //        }
            //        else if (Promedio > 70 && Promedio <= 85)
            //        {
            //            Tipo_alumno = "Bueno";
            //            break;
            //        }
            //        else if (Promedio > 85 && Promedio <= 100)
            //        {
            //            Tipo_alumno = "Excelente";
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Nota extratosfericamente invalida");
            //            Bandera = false;
            //            break;
            //        }

            //    }
            //    if (Bandera) {
            //        Console.WriteLine("Nombre: " + nombre.ToString() + "\nSexo: " + sexo.ToString() + "\nPromedio: " + Promedio.ToString() + "\nTipo de Alumno: " + Tipo_alumno.ToString());

            //    }


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string cadena = "a b c d e f g h i j k l m n ñ o p q r s t u v w x y z";
            //int[,] numeros = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            //foreach (char k in cadena)
            //{
            //    Console.Write(k.ToString());
            //}
            Console.ReadKey();
        }
    }
}
