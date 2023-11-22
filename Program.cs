using GestionEmpleados;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Gestión de Empleados *****\n");

        // Solicitar datos al usuario para Empleado
        Console.WriteLine("Ingrese los datos del Empleado:");
        Console.Write("Nombre: ");
        string nombreEmpleado = Console.ReadLine();
        Console.Write("Salario: ");
        double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

        // Crear instancia de Empleado
        Empleado empleado = new Empleado { Nombre = nombreEmpleado, Salario = salarioEmpleado };

        Console.WriteLine("\n*****");

        // Solicitar datos al usuario para Gerente
        Console.WriteLine("Ingrese los datos del Gerente:");
        Console.Write("Nombre: ");
        string nombreGerente = Console.ReadLine();
        Console.Write("Salario: ");
        double salarioGerente = Convert.ToDouble(Console.ReadLine());
        Console.Write("Departamento: ");
        string departamentoGerente = Console.ReadLine();

        // Crear instancia de Gerente
        Gerente gerente = new Gerente
        {
            Nombre = nombreGerente,
            Salario = salarioGerente,
            departamentoSupervisado = departamentoGerente
        };

        Console.WriteLine("\n*****");

        // Mostrar información utilizando polimorfismo
        Console.WriteLine("\nInformación del Empleado:");
        mostrarInformacion(empleado);

        Console.WriteLine("\nInformación del Gerente:");
        mostrarInformacion(gerente);

    }

    static void mostrarInformacion(IMostrarInformacion obj)
    {
        obj.mostrarInformacion();
    }
}
