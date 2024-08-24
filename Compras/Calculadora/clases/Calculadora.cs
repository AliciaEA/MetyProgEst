using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.clases
{
    internal class Calc
    {
        public double ElevarCubo(int numero)
        {
            return Math.Pow(numero, 3);
        }
        public double CalcularRaizCuadrada(int numero)
        {
            return Math.Sqrt(numero);
        }
    }
}
