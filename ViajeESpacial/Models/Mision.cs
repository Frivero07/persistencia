using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeESpacial.Models
{
    public abstract class Mision
    {
        public string Nombre {  get; private set; }
        public Destinos Destinos { get; private set; }
        public int Astronautas { get; private set; }

        public Mision(string nombre, Destinos destinos,int astronautas)
        {
            Nombre = nombre;
            Destinos = destinos;
            Astronautas = astronautas;
        }

        public abstract double CalcularDuracion();

        public override abstract string ToString();
        
    }

    
}
