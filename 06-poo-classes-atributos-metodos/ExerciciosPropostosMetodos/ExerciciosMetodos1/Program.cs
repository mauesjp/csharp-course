using Exercicio1Metodos;
using System.Globalization;

namespace exMetodos {
    class Program {
        static void Main(string[] args) {

            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA: {x.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: {x.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {x.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}