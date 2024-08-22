namespace AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, cargo;
            double salarioAnterior, aumento, salarioFinal;

            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el cargo: ");
            cargo = Console.ReadLine();
            Console.Write("Ingrese el salario: ");
            salarioAnterior = double.Parse(Console.ReadLine());

            aumento = salarioAnterior * 0.1;

            salarioFinal = salarioAnterior + aumento;

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"Salario anterior: {salarioAnterior}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario final: {salarioFinal}");
        }
    }
}
