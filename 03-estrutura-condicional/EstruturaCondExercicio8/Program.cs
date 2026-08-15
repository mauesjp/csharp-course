using System.Globalization;

namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o Valor do Salário:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double imposto;

            if(salario <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00) {

                imposto = (salario - 2000.00) * 0.08;
                
                Console.WriteLine($"R$ {imposto.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if(salario <= 4500.00) {
                imposto = (salario - 3000.00) * 0.18 + (1000.00 * 0.08);

                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                imposto = (salario - 4500.00) * 0.28 + (1500.00 * 0.18) + (1000.00 * 0.08);

                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}