using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeESpacial.Models
{
    public class Investigacion : Mision
    {
        public string CampoInvestigacion {  get; private set; }
        public Investigacion(string nombre, Destinos destinos, int astronautas, string campoinvestigacion) : base(nombre, destinos, astronautas) { }

        public override double CalcularDuracion()
        {
            return Astronautas * 5 + (int)Destinos * 2;

        }

        public override string ToString()
        {
             return $"{GetType().Name}, {Nombre}, {Destinos}, {Astronautas}, {CampoInvestigacion}";
        }
    }
}
