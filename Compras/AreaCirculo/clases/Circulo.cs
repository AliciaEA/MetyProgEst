using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo.clases
{
    internal class Circulo
    {
        public double Radio;

        public double calcularArea()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }

        public double calcularPerimetro()
        {
            return Math.PI * 2 * this.Radio;
        }
    }
}
