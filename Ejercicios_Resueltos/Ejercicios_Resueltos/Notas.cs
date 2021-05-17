using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Resueltos
{
    class Notas
    {
        string nombre_alumno;
        double Nota_alumno;
        string curso_alumno;
        string tipo_alumno;

       public Notas() {
            nombre_alumno = "";
            Nota_alumno = 0.00;
            curso_alumno = "";
            tipo_alumno = "";
        }
        public string Tipo_alimno(double nota) {
            if (nota < 60) {
                return ("Malo");
            }
            else {
                return ("BUeno");
            }

        }
        public void Solicitar_Datos(string nombre, double nota, string curso) {

            nombre_alumno = nombre;
            Nota_alumno = nota;
            curso_alumno = curso;
            tipo_alumno = Tipo_alimno(nota);
        }
        public string Mostrar_Datos() {
            return ("Nombre del alumno: "  +nombre_alumno.ToString() + "\n Nota del Alumno:  " + Nota_alumno.ToString() + "\n Curso_alumno: " +curso_alumno .ToString() +" \n Tipo_alumno: "  + tipo_alumno.ToString());

        }
    }
}
