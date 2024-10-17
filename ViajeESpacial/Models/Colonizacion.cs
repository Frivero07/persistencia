using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeESpacial.Models
{
     public class Colonizacion : Mision
     {
        public int Colonos {  get; private set; }
        public Colonizacion(string nombre, Destinos destinos, int astronautas,int colonos) : base(nombre, destinos, astronautas) { }
        public override double CalcularDuracion()
        {
            return Astronautas * 2.5 + (int)Destinos * 3.5;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, {Nombre}, {Destinos}, {Astronautas}, {Colonos}";
        }
    }
}
