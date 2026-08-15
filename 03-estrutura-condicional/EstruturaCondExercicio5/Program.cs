
using System.Globalization;

namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o código do produto e quantidade:");
            string[] entrada = Console.ReadLine().Split(' ');

            int codigo = int.Parse(entrada[0]);
            int qtd = int.Parse(entrada[1]);
            double total = 0.00;

            if (codigo == 1) {

                total = qtd * 4.00; 
            }
            else if(codigo == 2) {
                total = qtd * 4.50;
            }
            else if(codigo == 3) {
                total = qtd * 5.00;
            }
            else if(codigo == 4) {
                total = qtd * 2.00;
            }
            else {
                total = qtd * 1.50;
            }

            Console.WriteLine($"Total: R${total.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}