namespace BuclesWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do While Loop
            int counter = 0;

            Console.WriteLine("Start of Do While Loop");
            do
            {
                
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter <= 10);
            Console.WriteLine("End of Do While Loop \n\n");


            //For Loop
            Console.WriteLine("Start of For Loop");
            for (int i = 7; i <= 17; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }

            Console.WriteLine("\n");

            for (int row = 1; row < 3; row++)
            {
                for (char column = 'a'; column < 'd'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            Console.WriteLine("End of For Loop \n\n");


            //Combinación de ramas y bucles
            int suma = 0;
            Console.WriteLine("Suma de todos los enteros de uno a veinte que se puedan dividir entre tres");
            for (int i = 1; i <= 20; i++)
            {
                if (i%3 == 0)
                {
                    Console.WriteLine($"El número {i} es divisible entre 3");
                    suma += i;
                }
            }
            Console.WriteLine($"La suma de los números divisibles entre 3 es {suma}");

        }
    }
}
