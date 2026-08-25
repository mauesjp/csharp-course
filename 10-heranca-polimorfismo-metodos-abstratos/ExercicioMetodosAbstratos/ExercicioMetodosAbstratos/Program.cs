using ExercicioMetodosAbstratos.Entities;
using System.Globalization;

namespace ExercicioMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                    Console.WriteLine();
                }
                else if (ic == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                    Console.WriteLine();
                }

            }
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach (TaxPayer payer in list)
            {
                sum += payer.Tax();
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.Write($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
