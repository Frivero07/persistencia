using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareas.Modelos
{
    public class Tarea
    {
        public string Descripcion {  get; set; }

        public bool Completada { get; set; }
        // ya por defecto viene completada
        public Tarea(string descripcion,bool completada = false)
        {
            Descripcion = descripcion;
            Completada = completada;
        }
        // convierte todo a string 
     public override string ToString()
        {
            // ternaria
            return $"{Descripcion} - {(Completada ? "Completada" : "pendiente")}";
        }
    }
}
