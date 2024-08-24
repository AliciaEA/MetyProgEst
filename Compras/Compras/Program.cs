using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");
            Factura factura = new Factura();

            string producto = null;
            double precio= 0, monto;
            int cantidad = 0;

            Console.Write("Producto: ");
            producto = Console.ReadLine();
            Console.Write("Precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            factura.Producto = producto;
            factura.Precio = precio;
            factura.Cantidad = cantidad;

            monto = factura.calcularMonto();



            Console.WriteLine($"{producto}");
            Console.WriteLine($"{precio}");
            Console.WriteLine($"{cantidad}");
            Console.WriteLine($"{monto}");


        }
    }
}
