using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    /* // 1. Definicion de clases
     public class Empleado
     {
         //Atributos
         public string Nombre { get; set; }
         public double Salario { get; set; }

         //Metodo para calcular el salario anual
         public double calcularSalarioAnual()
         {
             return Salario * 12;
         }

     }*/

    // 4. Implementación de la interfaz en la clase Empleado
    public class Empleado : IMostrarInformacion
    {
        //Atributos
        public string Nombre { get; set; }
        public double Salario { get; set; }
        //Metodo para calcular el salario anual
        public double calcularSalarioAnual()
        {
            return Salario * 12;
        }

        //Metodo para mostrar la informacion
        public void mostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Salario Anual: {calcularSalarioAnual()}");
        }
    }

}
