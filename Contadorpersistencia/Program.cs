public static class Sistema
{
    /*
     * La pila Palabras permite almacenar múltiples diccionarios, cada uno representando las palabras y sus frecuencias de una frase ingresada.
     * Esto es útil si deseas llevar un registro de las palabras contadas en varias frases a lo largo del tiempo.
     */
    static Stack<Dictionary<string,int>> Palabras = new Stack<Dictionary<string,int>>();
    static readonly string archivo = "palabras.txt";
    static readonly string Separador = "-";

    public static void AgregarFrace()
    {
        Console.WriteLine("Ingrese la frace");
        string frase = Console.ReadLine();
        //la frace se divide en palabras en espacion y se guarda en el string 
        string[] palabras = frase.Split(' ');
        Dictionary<string,int> contadorpalabras = new Dictionary<string,int>();
        foreach (string palabra in palabras)
        {
            if (contadorpalabras.ContainsKey(palabra))
            {
                contadorpalabras[palabra] += 1;
            }
            else
            {
                contadorpalabras.Add(palabra, 1);
            }
        }
        //funciona para el stack y añade las palabras al diccionario 
        Palabras.Push(contadorpalabras);
        Console.WriteLine("\n");
    }
    public static void Mostrarfrecuenciafrase()
    {
        Console.WriteLine("ingrese la palabra  que busca");
        string frase = Console.ReadLine();

        Console.WriteLine("Frecuencia de palabras:");
        //cada diccionario contiene un conteo de palabras 
        foreach(Dictionary<string,int> diccionarios in Palabras)
        {
            foreach (string clave in diccionarios.Keys)
            //Iteración sobre las claves: Dentro del primer bucle,
            //se inicia otro bucle que itera sobre las claves del diccionario actual (diccionarios).
            //Las claves son las palabras que se contaron.
            {
                Console.WriteLine($"{clave}|{diccionarios[clave]}");
            }
        }
    }
    public static void Mostrarfrecuenciapalabra()
    {
        Console.WriteLine("Ingrese la palabra que busca:");
        string palabraBuscada = Console.ReadLine();

        Console.WriteLine("Frecuencia de la palabra:");

        bool encontrada = false; // Variable para verificar si la palabra fue encontrada

        foreach (Dictionary<string, int> diccionarios in Palabras)
        {
            // Comprobar si el diccionario contiene la palabra buscada
            if (diccionarios.ContainsKey(palabraBuscada))
            {
                // Si existe, imprimir la frecuencia
                Console.WriteLine($"{palabraBuscada}|{diccionarios[palabraBuscada]}");
                encontrada = true; // Marcamos que hemos encontrado la palabra
            }
        }

        // Mensaje si la palabra no fue encontrada en ningún diccionario
        if (!encontrada)
        {
            Console.WriteLine($"La palabra '{palabraBuscada}' no se encontró en ninguna frase.");
        }
    }

    public static void GuardarSistema()
    {
        using StreamWriter writer = new StreamWriter(archivo);
        foreach (var diccionario in Palabras)
        {
            foreach(var clave in diccionario.Keys)
            {
            writer.WriteLine($"{clave}|{diccionario[clave]}");

            }
            writer.WriteLine(Separador);
        }
        Console.WriteLine("Datos guardados correctamente");
    }

}
public class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("1.agregar frase");
            Console.WriteLine("2.Mostar  frase");
            Console.WriteLine("3.Mostar palabra buscada");
            Console.WriteLine("4.guardar y salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Sistema.AgregarFrace();
                    break;
                case 2:
                    Sistema.Mostrarfrecuenciafrase();
                    break;
                case 3:
                    Sistema.Mostrarfrecuenciapalabra();
                    break;
              
            }

        } while (opcion != 4);
        Sistema.GuardarSistema();
     

    }
}

