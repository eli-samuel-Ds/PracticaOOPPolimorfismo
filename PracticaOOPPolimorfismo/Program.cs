using System;
using PracticaOOPPolimorfismo;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Docente Por Hora
            DocenteHora docenteHora1 = new DocenteHora("Julian", "Senesa", 12);
            //Docente Fijo
            DocenteFijo docenteFijo1 = new DocenteFijo("Lisa", "Almidon", 50000, true);
            DocenteFijo docenteFijo2 = new DocenteFijo("Laurel", "Almidon", 50000, false);
            //Empleado Administrativo
            EmpleadoAdministrativo empleadoAdministrativo1 =
                new EmpleadoAdministrativo("Lucas", "Senasa", 100000, 20000, true);
            EmpleadoAdministrativo empleadoAdministrativo2 =
                new EmpleadoAdministrativo("Lori", "Senasa", 100000, 20000, false);

            Console.WriteLine("Salario Mensual Compania");
            Console.WriteLine("Docente Por Hora");
            Console.WriteLine($"-|{docenteHora1.MostrarInformacion()}");

            Console.WriteLine("\nDocente Fijo");
            Console.WriteLine($"--|{docenteFijo1.MostrarInformacion()}");
            Console.WriteLine($"--|{docenteFijo2.MostrarInformacion()}");

            Console.WriteLine("\nEmpleado Administrativo");
            Console.WriteLine($"---|{empleadoAdministrativo1.MostrarInformacion()}");
            Console.WriteLine($"---|{empleadoAdministrativo2.MostrarInformacion()}");
        }
    }
}