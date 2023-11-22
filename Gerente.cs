using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados
{
    // 2. Herencia
    /*
    public class Gerente : Empleado
    {
        //Nuevo Atributo
        public string departamentoSupervisado { get; set; }

    }*/

// 4. Implementación de la interfaz en la clase Gerente
public class Gerente : Empleado, IMostrarInformacion
    {
        //Atributo
        public string departamentoSupervisado { get; set; }

        // Método para mostrar información
        public new void mostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Salario Anual: {calcularSalarioAnual()}, Departamento a Cargo: {departamentoSupervisado}");
        }
    }
}
