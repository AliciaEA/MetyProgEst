using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10, And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10, Or the first number is not equal to the second");
            }
           
           
            Console.ReadKey();
        }
    }
}
