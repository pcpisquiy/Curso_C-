using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO
{
    class Carro
    {
       private bool encendido;
       public bool Estado_frenos;
       private bool Estado_acelerar;
       private int pasos;
       private string cambiar_velociada;
       public int distancia_recorrida;
       public int tiempo;
      public Mecanico mecanico = new Mecanico();

       public  Carro() {

           encendido = true;
           Estado_frenos = true;
           Estado_acelerar = false;
           pasos = 0;
           cambiar_velociada = "N";
           tiempo = 0;
           distancia_recorrida = 0;
       }

        // public void nombre(parametros a recibir){
        // <codigo>
        //}

        // public Tipo nombre(parametros a recibir){
        // <codigo>

        //return(variable tipo)
        //}

       public bool frenar() {
           Estado_acelerar = !Estado_acelerar;
           Estado_frenos = !Estado_frenos;
           return Estado_frenos;
       }

       public void Cambiar_velocidad(string vel) {
            switch(vel){
                case"N":
                    cambiar_velociada=vel;
                    pasos = 0;
                    break;
                case "1":
                    cambiar_velociada=vel;
                    pasos = 1;
                    break;
                case "2":
                    cambiar_velociada=vel;
                    pasos = 2;
                    break;
                case "3":
                    cambiar_velociada=vel;
                    pasos = 3;
                    break;
                case "4":
                    cambiar_velociada=vel;
                    pasos = 4;
                    break;
                case "5":
                    cambiar_velociada=vel;
                    pasos = 5;
                    break;
                case "R":
                    cambiar_velociada=vel;
                    pasos = -1;
                    break;
            
            }
       }
        public int caminar(){
        
            do{
                tiempo += 1;
                Random rnd = new Random();
                int velo = rnd.Next(1, 5);
                Cambiar_velocidad(velo.ToString());
                return (distancia_recorrida+=pasos);
            }while(Estado_acelerar);
        }
       public void calcular_velocidad(string marca_carro, int distancia, int tiempo_h){
           Console.WriteLine("Marca: "+ marca_carro.ToString()+"\n"+"La velociada es de : "+ (distancia/tiempo_h).ToString()+" KM/H");  
       }
}


    }
