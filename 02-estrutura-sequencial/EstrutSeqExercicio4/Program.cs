
using System.Globalization;

namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o número do colaborador:");
            int numeroCol = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira suas horas trabalhadas:");
            int horasCol = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da sua hora:");
            double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario = horasCol * valorHora;

            Console.WriteLine($"Colaborador: {numeroCol}");
            Console.WriteLine($"Salario: R${salario.ToString("F2",CultureInfo.InvariantCulture)}");



        }
    }
}
