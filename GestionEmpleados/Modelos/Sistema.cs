using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GestionEmpleados.Modelos
{
    static public class Sistema
    {
       static Dictionary<int,Empleado> Empleados = new Dictionary<int,Empleado>();
       static string ArchivoEmpleados = "empledos.txt";

        static public void MostrarEmpleados()
        {
            Console.WriteLine("\nLista de empleados");
            //para recorrer los valores de los empleados 
            foreach (var empleado in Empleados.Values)
            {
                Console.WriteLine(empleado);
            }
        }

        static public void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el ID del empleado:");
            //esto lo va a pedir en el parcial
            int id, edad,depindex;
            string nombre = "";
            Departamento departamento = Departamento.RecursosHumanos;
            bool valid;
            do
            {
                Console.WriteLine("Ingrese ID del empleado");
                valid = int.TryParse(Console.ReadLine(), out id);
                if (!valid) { Console.WriteLine("El dato no es de tipo entero"); }
                    
            }
            while (!valid);
            valid = false;
            do
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                var dato = Console.ReadLine();
                
                if (string.IsNullOrEmpty(dato))
                {
                    Console.WriteLine("el nombre no debe estar vacio");
                }
                else
                {
                    valid = true;
                    nombre = Console.ReadLine();
                }

            }
            while (!valid);
            valid = false;
            do
            {
                Console.WriteLine("Ingrese la edad del empleado");
                valid = int.TryParse(Console.ReadLine(), out edad);
                if (!valid) { Console.WriteLine("El dato no es de tipo entero"); }

            }
            while (!valid);

            valid = false;
            do
            {
                Console.WriteLine("Selecione el departamento del empleado: ");
                //te devueve el tipo de lo que le pases 
                foreach(var dep in Enum.GetValues(typeof(Departamento)))
                {
                    //esto da la pocicion del enum 
                    Console.WriteLine($"{(int)dep}, {dep}");
                }
                valid = int.TryParse(Console.ReadLine(),out depindex);
                if (!valid) { Console.WriteLine("El dato no es de tipo entero"); }
                else
                {
                   departamento = (Departamento) depindex;
                }

            }
            while (!valid);

            var emp = new Empleado(id, nombre, edad, departamento);
            Empleados.Add(id, emp);
            Console.WriteLine("Empleado Agregado");
        }

    }
}
