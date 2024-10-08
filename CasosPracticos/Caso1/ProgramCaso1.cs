using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso1
{
    public class ProgramCaso1
    {
        public static void Main(string[] args)
        {
            RegistroUsuarios registro = new RegistroUsuarios();
            string opcion;

            do
            {
                Console.WriteLine("1. Registrar un usuario");
                Console.WriteLine("2. Listar usuarios");
                Console.WriteLine("3. Volver al menú principal");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el email: ");
                        string email = Console.ReadLine();
                        registro.RegistrarUsuario(nombre, email);
                        Console.WriteLine("Usuario registrado con éxito.\n");
                        break;

                    case "2":
                        registro.ListarUsuarios();
                        break;

                    case "3":
                        return; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != "3");
        }
    }
}
