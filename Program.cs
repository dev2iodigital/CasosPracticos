using System;

namespace ConsoleAppTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("Selecciona el Caso Práctico a ejecutar:");
                Console.WriteLine("1. Caso Práctico 1: Registro de Usuarios");
                Console.WriteLine("2. Caso Práctico 2: Gestión de Empleados");
                Console.WriteLine("3. Caso Práctico 3: Asincronía de Tareas");
                Console.WriteLine("4. Salir");
                Console.WriteLine(Environment.NewLine);

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        TestEntrevistas.CasosPracticos.Caso1.ProgramCaso1.Main(args);
                        break;
                    case "2":
                        TestEntrevistas.CasosPracticos.Caso2.ProgramCaso2.Main(args);
                        break;
                    case "3":
                        TestEntrevistas.CasosPracticos.Caso3.ProgramCaso3.Main(args);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != "4");
        }
    }
}