namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;

            Console.WriteLine("Ingrese el radio del círculo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
