using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.clases
{
    internal class Factura
    {
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public double calcularMonto()
        {             
            return this.Precio * this.Cantidad;
        }

        public Factura() { }
    }
}
