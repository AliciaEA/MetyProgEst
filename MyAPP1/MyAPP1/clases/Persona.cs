using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2.clases
{
    internal class Persona
    {
        public Persona() { }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNac.Year;
        }

        public string EvaluarEdad()
        {
            if (CalcularEdad() >= 18) return "Es mayor de edad";
            return "Es menor de edad";
        }
    }
}
