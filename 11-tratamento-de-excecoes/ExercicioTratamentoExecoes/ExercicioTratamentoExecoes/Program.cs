using ExercicioTratamentoExecoes.Entities;
using ExercicioTratamentoExecoes.Entities.Exceptions;
using System.Globalization;

namespace ExercicioTratamentoExecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

                Account account = new Account(numberAccount, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);

                Console.WriteLine($"New Balance: ${account.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
