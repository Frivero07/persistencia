namespace ViajeEspacial.Models
{
    static public class GestionMisiones
    {
        static List<Mision> Misiones { get; set; } = new List<Mision>();
        static string ArchivoMisiones = "misiones.txt";

        static public void AgregarMision(Mision mision)
        {
            Misiones.Add(mision);
            Console.WriteLine($"Misión {mision.Nombre} ha sido agregada.");
        }

        static public void MostrarMisiones()
        {
            if (Misiones.Count == 0) {
                Console.WriteLine("No hay misiones registradas.");
            }
            else
            {
                Console.WriteLine("\nLista de misiones: ");
                foreach (var mision in Misiones)
                {
                    Console.WriteLine(mision);
                }
            }
        }

        static public void ModificarMision(string nombre, Mision nuevaMision)
        {
            var mision = Misiones.Find(m => m.Nombre == nombre);

            if (mision == null)
            {
                Console.WriteLine($"Misión '{nombre}' no encontrada.");
            }
            else
            {
                Misiones.Remove(mision);
                Misiones.Add(nuevaMision);
                Console.WriteLine($"Misión '{nombre}' ha sido modificada.");
            }
        }

        static public void EliminarMision(string nombre)
        {
            var mision = Misiones.Find(m => m.Nombre == nombre);

            if (mision == null)
            {
                Console.WriteLine($"Misión '{nombre}' no encontrada.");
            }
            else
            {
                Misiones.Remove(mision);
                Console.WriteLine($"Misión '{nombre}' ha sido eliminada.");
            }
        }
    }
}
