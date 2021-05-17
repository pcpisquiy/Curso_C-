using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro objCar = new Carro();
            try {
                objCar.frenar();
                objCar.Cambiar_velocidad("5");
                while (true) {
                    Console.Clear();
                    if (objCar.Estado_frenos)
                    {
                        Console.WriteLine("Desea Acelerar?");
                        if (Console.ReadLine() == "Y")
                        {
                            objCar.frenar();
                        }
                    }
                    else
                    {
                        Console.WriteLine(objCar.caminar().ToString() + " km");
                        objCar.calcular_velocidad("HONDA", objCar.distancia_recorrida, objCar.tiempo);
                        Thread.Sleep(1500);
                        //Console.WriteLine("Desea Frenar?");
                        //if (Console.ReadLine() == "Y")
                        //{
                        //    objCar.frenar();
                        //}
                        //Console.WriteLine("Desea Cambiar la velocidad?");
                        //objCar.Cambiar_velocidad(Console.ReadLine());
                    }

                
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            
            }
            Console.ReadKey();
        }
    }
}
