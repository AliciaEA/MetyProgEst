using AreaCirculo.clases;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            double radio = 0, resultado = 0;

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido, que quieres calcular?");
                Console.WriteLine("1. Calcular Area de un Circulo ");
                Console.WriteLine("2. Calcular Perimetro de un Circulo");
                Console.WriteLine("3. Salir");
                Console.Write("Escoge la opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Proporciona el radio del circulo: ");
                        radio = double.Parse(Console.ReadLine());

                        circulo.Radio = radio;

                        resultado = circulo.calcularArea();

                        Console.WriteLine($"El area del circulo es de {resultado}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Proporciona el radio del circulo: ");
                        radio = double.Parse(Console.ReadLine());

                        circulo.Radio = radio;

                        resultado = circulo.calcularPerimetro();

                        Console.WriteLine($"El perimetro del circulo es de {resultado}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Gracias, ten buen dia");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 3);


        }
    }
}
