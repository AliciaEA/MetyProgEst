namespace NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Bienvenido, proporciona tres numeros y te indicaremos el mayor de ellos");
            Console.Write("Primer Numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Tercer Numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El numero mayor es: {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"El numero mayor es: {num2}");
            }
            else
            {
                Console.WriteLine($"El numero mayor es: {num3}");
            }

        }

    }

}
