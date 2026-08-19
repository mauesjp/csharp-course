using System.Globalization;

namespace ExercicioFixacaoCapitulo {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            ContaBancaria contaBancaria = new ContaBancaria(conta, nome);
            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());
            double depositoInicial;

            if (deposito == 's') {
                Console.Write("Entre o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contaBancaria.Depositar(depositoInicial);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            contaBancaria.Depositar(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

        }
    }
}
