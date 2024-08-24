using CalcularNota.clases;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota();
            double primerCorte = 0, segundoCorte = 0, tercerCorte = 0, notaFinal = 0;

            Console.WriteLine("Bienvenido, calculemos tu nota final...");
            Console.WriteLine("Por favor, ingrese los siguientes datos");
            Console.Write("Primer corte: ");
            primerCorte = double.Parse(Console.ReadLine());
            Console.Write("Segundo corte: ");
            segundoCorte = double.Parse(Console.ReadLine());
            Console.Write("Tercer corte: ");
            tercerCorte = double.Parse(Console.ReadLine());

            nota.PrimerCorte = primerCorte;
            nota.SegundoCorte = segundoCorte;
            nota.TercerCorte = tercerCorte;

            notaFinal = nota.CalcularNotaFinal();

            Console.WriteLine($"Tu nota final es: {notaFinal}");

        }
    }
}
