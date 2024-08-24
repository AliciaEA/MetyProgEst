using Calculadora.clases;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
           Calc calculadora = new Calc();
            double resultado = 0;
            int opcion = 0, numero = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la calculadora");
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Elevar al cubo");
                Console.WriteLine("2. Calcular raiz cuadrada");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un numero: ");
                        numero = int.Parse(Console.ReadLine());
                        resultado = calculadora.ElevarCubo(numero);
                        Console.WriteLine($"El resultado de elevar al cubo es: {resultado} ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Ingrese un numero: ");
                        numero = int.Parse(Console.ReadLine());
                        resultado = calculadora.CalcularRaizCuadrada(numero);
                        Console.WriteLine($"El resultado de la raiz cuadrada es: {resultado}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar la calculadora");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != 3);

        }
    }
}
