using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisionesIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            Console.ReadKey();
        }
    }
}
