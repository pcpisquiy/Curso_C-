using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condiciones
/*/
             * if<condicion>
             *{
             *}
             *-----------------------  
             * if<condicion>
             *{
             *}else if<Condicion>{}
             *else{}
             *
             *switch(<Condicion>)
             *case:
             *break;
             *
             * default:
             * break;
             * /*/
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Ingese el nombre del alumno");
                string nombre = Console.ReadLine().ToString();
                Console.WriteLine("Ingese el Sexo del alumno M/F");
                string sexo = Console.ReadLine().ToString();
                Console.WriteLine("Ingese la nota del alumno del alumno");
                double Promedio = Convert.ToDouble(Console.ReadLine().ToString());
                string Tipo_alumno = "";
                Console.Clear();
                //==
                //!=
                //<=
                //>=
                //<
                //>
                switch (sexo.ToUpper())
                {
                    case "M":
                        sexo = "MASCULINO";
                    break;
                    case "F":
                        sexo = "FEMENINO";
                    break;
                    default:
                    Console.Clear();
                    Console.WriteLine("Sexo invalido");
                    break;

               }
                if (Promedio < 60) {
                    Tipo_alumno = "Malo";

                }
                else if (Promedio >= 60 && Promedio <= 70) {
                    Tipo_alumno = "Regular";

                }
                else if (Promedio > 70 && Promedio<=85) {
                    Tipo_alumno = "Bueno";
                }
                else if (Promedio > 85 && Promedio <= 100)
                {
                    Tipo_alumno = "Excelente";
                }
                else {
                 Console.WriteLine("Nota extratosfericamente invalida");
                }
                Console.WriteLine("Nombre: "+nombre.ToString()+"\nSexo: "+sexo.ToString()+"\nPromedio: "+Promedio.ToString()+"\nTipo de Alumno: "+Tipo_alumno.ToString());
            }     
            catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }
            Console.ReadKey();
        }
    }
}
