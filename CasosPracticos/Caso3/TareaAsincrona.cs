using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso3
{
    public class TareaAsincrona
    {
        public async Task EjecutarTarea(string nombreTarea, int duracion)
        {
            Console.WriteLine($"Iniciando {nombreTarea}");
            await Task.Delay(duracion);
            Console.WriteLine($"{nombreTarea} completada en {duracion} ms.");
        }

        public async Task EjecutarTodasLasTareas()
        {
            await EjecutarTarea("Tarea 1", 2000);
            await EjecutarTarea("Tarea 2", 3000);
            await EjecutarTarea("Tarea 3", 1000);
        }
    }
}
