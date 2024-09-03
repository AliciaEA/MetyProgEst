using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseIf.models
{
    internal class Evaluation
    {
        public Evaluation() { }
        public string EvaluarEdad(int edad)
        {
            
                if (edad >= 0 && edad <= 12) return "Eres un niño";
                else if (edad >= 13 && edad <= 25) return "Eres un joven";
                else if (edad >= 26) return "Eres un adulto";
                return "Edad no válida";
            
            
        }
    }
}
