using ExercicioMembrosEstaticos;
using System.Globalization;

namespace exMemEstaticos {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Conversao(cotacao, quantidade);

            Console.Write($"Valor a ser pago em reais = {valor.ToString("F2",CultureInfo.InvariantCulture)}");
            
        }
    }
}
