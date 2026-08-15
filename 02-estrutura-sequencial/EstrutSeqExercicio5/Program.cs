
using System.Globalization;

namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira Código, quantidade e valor unitário da peça 1:");
            string[] v = Console.ReadLine().Split(' ');

            int codP1 = int.Parse(v[0]);
            int qtdP1 = int.Parse(v[1]);
            double vlrP1 = double.Parse(v[2],CultureInfo.InvariantCulture);

            Console.WriteLine("Insira Código, quantidade e valor unitário da peça 2:");
            string[] s = Console.ReadLine().Split(' ');

            int codP2 = int.Parse(s[0]);
            int qtdP2 = int.Parse(s[1]);
            double vlrP2 = double.Parse(s[2],CultureInfo.InvariantCulture);

            double soma1 = vlrP1 * qtdP1;
            double soma2 = vlrP2 * qtdP2;

            double soma = soma1 + soma2;

            Console.WriteLine($"VALOR A PAGAR: R${soma.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
