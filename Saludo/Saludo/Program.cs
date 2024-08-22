namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //Leer el nombre y saludar
            Console.Write("Bienvenido, proporciona tu nombre y apellido: ");
            nombre = Console.ReadLine();

            Console.WriteLine($"Hola {nombre}, te mandamos un gran saludo");
        }
    }
}
