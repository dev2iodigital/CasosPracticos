using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso2
{
    public class ProgramCaso2
    {
        public static void Main(string[] args)
        {
            GestionEmpleados gestion = new GestionEmpleados();
            gestion.AgregarEmpleado("Juan", 1000);
            gestion.AgregarEmpleado("Ana", 1500);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Antes de la actualización:");
            gestion.ListarEmpleados();
            
            gestion.ActualizarSalario("Juan", 1200);

            Console.WriteLine("Después de la actualización:");
            gestion.ListarEmpleados();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
