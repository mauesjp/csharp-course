
using System.Globalization;

namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira os valores A, B e C:");
            string[] v = Console.ReadLine().Split(' ');

            double A = double.Parse(v[0],CultureInfo.InvariantCulture);
            double B = double.Parse(v[1],CultureInfo.InvariantCulture);
            double C = double.Parse(v[2],CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = (A * C) / 2.0;
            double circulo = pi * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
