using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas.Modelos
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> usuarios = new();
        //solo lectura 
        static readonly string archivo = "usuarios.txt";
        static readonly string UsuarioSeparador = "-";

        public static void AgregarUsuario()
        {
            Console.WriteLine("Ingrese el nombre usuario");
            string nombreUsuario = Console.ReadLine();

            if (!usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario] = new Usuario(nombreUsuario);
                Console.WriteLine($"Usuario{nombreUsuario} agregado ");

            }
            else
            {
                Console.WriteLine("Usuario existente");
            }
        }

        public static void AgregarTareaUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombreUsuario = Console.ReadLine();
            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("ingrese los datos de la tarea");
                string descripcion = Console.ReadLine();
                Tarea tarea = new Tarea(descripcion);

                usuarios[nombreUsuario].AgregarTarea(tarea);
                Console.WriteLine($"Tarea agregada al usuario {nombreUsuario}");

            }
            else
            {
                Console.WriteLine("Usuario inexistente");
            }

        }
        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.WriteLine("Ingrese el nombre usuario");
            string nombreUsuario = Console.ReadLine();

            if (!usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("Ingrese el numero de la tarea a cambiar (empezando desde 0):");
                int indice = int.Parse(Console.ReadLine());
                //acceder al usuario y cambiar el estado
                usuarios[nombreUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado");

            }
            else
            {
                Console.WriteLine("Usuario existente");
            }
        }
        public static void MostrarTareasUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario");
            string nombreUsuario = Console.ReadLine();
            if (usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario].MostrarTareas();

            }
            else
            {
                Console.WriteLine("Usuario inexistente");
            }

        }
        public static void GuardarDatos()
        {
            //*ruta para leer el archivo
            // StreamWriter writer = new StreamWriter(archivo);
            //writer.

            using StreamWriter writer = new StreamWriter(archivo);
            foreach (var usuario in usuarios)
            {
                //linea entera de usuarios 
                writer.WriteLine(usuario.Key);
                foreach (var tarea in usuario.Value.tareas)
                {
                    writer.WriteLine($"{tarea.Descripcion}|{tarea.Completada}");

                }
                writer.WriteLine(UsuarioSeparador);
            }
            Console.WriteLine("los datos fueron guardados correctamente");
        }
    }
}

       


   

