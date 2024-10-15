using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeESpacial.Models
{
    public class Exploracion : Mision
    {
        public Exploracion(string nombre, Destinos destinos, int astronautas) : base(nombre, destinos, astronautas) { }
        
        public override double CalcularDuracion()
        {
            return Astronautas * 1.5 + (int)Destinos * 2;
        } 

        public override string ToString()
        {
            return $"{GetType().Name}, {Nombre}, {Destinos}, {Astronautas}";
        }
    }
}
