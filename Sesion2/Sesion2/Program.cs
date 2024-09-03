using Sesion2.clases;

namespace Sesion2
{
    internal class Program
    {
        //Leer los datos de una persona y decir si es mayor o menos de edad
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Persona persona = new Persona();

            Console.Write("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.Write("En que fecha naciste: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}
