using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso2
{
    public class GestionEmpleados
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(string nombre, decimal salario)
        {
            Empleado empleado = new Empleado { Nombre = nombre, Salario = salario };
            empleados.Add(empleado);
        }

        public void ActualizarSalario(string nombre, decimal nuevoSalario)
        {
            Empleado empleado = empleados.Find(e => e.Nombre == nombre);
            if (empleado != null)
            {
                Empleado nuevoEmpleado = empleado; 
                nuevoEmpleado.Salario = nuevoSalario; 
            }
        }

        public void ListarEmpleados()
        {
            Console.WriteLine("Lista de Empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}, Salario: {empleado.Salario}");
            }
        }
    }
}
