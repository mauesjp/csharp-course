using Exercicio2Metodos;
using System.Globalization;

namespace exMetodos {
    class Program {
        static void Main(string[] args) {

            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {x}");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double pct = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.AumentarSalario(pct);
            

            Console.WriteLine($"Dados Atualizados: {x}");
        }
    }
}
