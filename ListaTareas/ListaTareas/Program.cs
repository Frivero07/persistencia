using ListaTareas.Modelos;

namespace ListaTareas
{
class Program
{
    static void Main()
    {
            Sistema.CargarDatos();
            int opcion;
            do
            {
                Console.WriteLine("1.Agregar Usuario");
                Console.WriteLine("2.agregar Tarea a Usuario");
                Console.WriteLine("3.Cambiar estado de tarea ");
                Console.WriteLine("4.Mostrar todas las tareas");
                Console.WriteLine("5.guardar y salir");

            opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Sistema.AgregarTareaUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Sistema.CambiarEstadoTareaDeUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Sistema.MostrarTareasUsuario();
                        Console.WriteLine("\n");
                        break;
                }



            }
            while (opcion != 5);
            Sistema.GuardarDatos();
        }
}

}
