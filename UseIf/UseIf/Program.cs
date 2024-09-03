using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseIf.models;

namespace UseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            /*
             * Ninio: 0-12
             * joven: 13-25
             * Adulto: 26 a mas
             */
            int edad = 0;
            Evaluation evaluacion = new Evaluation();

            Console.WriteLine("Evaluar edad");
            Console.Write("Ingresa tu edad: ");
            try
            {
                edad = int.Parse(Console.ReadLine());
                string message = evaluacion.EvaluarEdad(edad);
                Console.WriteLine(message);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
                Console.ReadKey();
                return;
            }
            
        }
    }
}
