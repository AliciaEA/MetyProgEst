using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNota.clases
{
    internal class Nota
    {
        public double PrimerCorte { get; set; }
        public double SegundoCorte { get; set; }
        public double TercerCorte { get; set; }

        public Nota() { }
        public double CalcularNotaFinal()
        {
            return (this.PrimerCorte + this.SegundoCorte + this.TercerCorte) / 3;
        }
    }
}
