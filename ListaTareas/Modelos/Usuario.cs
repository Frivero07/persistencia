
namespace ListaTareas.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public List<Tarea> tareas { get; set; }

        public Usuario(string nombreUsuario)
        {
            Nombre = nombreUsuario;
            tareas = new List<Tarea>();
        }

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        public void MostrarTareas ()
        {
            Console.WriteLine($"Tareas de {Nombre}:");
            foreach (Tarea tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas aun.");
            }
        }
        //para cambiar el valor a una tarea
        public void CambiarEstadoTarea(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
            {
                tareas[indice].Completada = !tareas[indice].Completada;
            }
            else
            {
                Console.WriteLine(new IndexOutOfRangeException().Message);
            }
        }

    }
}
