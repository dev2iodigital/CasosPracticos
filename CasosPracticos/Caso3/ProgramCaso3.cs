using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso3
{
    public class ProgramCaso3
    {
        public static async Task Main(string[] args)
        {
            TareaAsincrona tareas = new TareaAsincrona();
            await tareas.EjecutarTodasLasTareas();
        }
    }
}
