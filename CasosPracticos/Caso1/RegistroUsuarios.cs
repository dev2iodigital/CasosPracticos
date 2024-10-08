using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntrevistas.CasosPracticos.Caso1
{
    public class RegistroUsuarios
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public void RegistrarUsuario(string nombre, string email)
        {
            Usuario usuario = new Usuario { Nombre = nombre, Email = email };
            usuarios.Add(usuario);
        }

        public void ListarUsuarios()
        {
            Console.WriteLine("Lista de Usuarios Registrados:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nombre: {usuario.Nombre}, Email: {usuario.Email}");
            }
        }
    }
}
