using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARRAYS
{
    class Program
    {
        static void Ordenar_vector(int [,] numeros) {
            int auxiliar = 0;
            for (int x1 = 0; x1 < numeros.GetLength(0); x1++)
            {
                for (int y1 = 0; y1 < numeros.GetLength(1); y1++)
                {
                    for (int x2 = x1; x2 < numeros.GetLength(0); x2++)
                    {
                        for (int y2 = y1; y2 < numeros.GetLength(1); y2++)
                        {
                            if (numeros[x1,y1] >= numeros[x2,y2])
                            {
                                auxiliar = numeros[x2, y2];
                                numeros[x2, y2] = numeros[x1, y1];
                                numeros[x1, y1] = auxiliar;

                            }
                        }
                    }

                }

            }
        }
        static void Main(string[] args)
        {
            //vector <tipo_dato> [] <nombre> = new <tipo_dato> [<numero casillas>]
            //Matriz <tipo_dato> [,] <nombre> = new <tipo_dato> [<numero filas>,<numero columnas>]
            int[,] numeros_aleatorios = new int[3,3]; 
            try {
                Random rnd = new Random();

                for (int x = 0; x < numeros_aleatorios.GetLength(0);x++ )
                {
                    for (int y = 0; y < numeros_aleatorios.GetLength(1); y++)
                    {
                        numeros_aleatorios[x,y] = Convert.ToInt32(rnd.Next(1, 10));

                        Console.Write(numeros_aleatorios[x, y].ToString() + " ");
                    }
                    Console.WriteLine();
                }
                Ordenar_vector(numeros_aleatorios);
                Console.WriteLine("VECTOR ORDENADO");
                for (int x = 0; x < numeros_aleatorios.GetLength(0); x++)
                {
                    for (int y = 0; y < numeros_aleatorios.GetLength(1); y++)
                    {

                        Console.Write(numeros_aleatorios[x, y].ToString()+" ");
                    }
                    Console.WriteLine();
                }


            
            }
            catch (Exception ex) {
                Console.WriteLine("ERROR: {0}.",ex);
            }


            Console.ReadKey();
        }
    }
}
