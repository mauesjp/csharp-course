using System.Globalization;

namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o valor do Raio:");
            double vRaio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double area = pi * (Math.Pow(vRaio, 2));

            Console.WriteLine($"A= {area.ToString("F4",CultureInfo.InvariantCulture)}");


        }
    }
}
