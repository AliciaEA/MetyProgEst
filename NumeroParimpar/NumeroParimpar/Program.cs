namespace NumeroParimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Bienvenido, Proporciona un numero para saber si es par o impar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar");
            }


        }
    }
}
