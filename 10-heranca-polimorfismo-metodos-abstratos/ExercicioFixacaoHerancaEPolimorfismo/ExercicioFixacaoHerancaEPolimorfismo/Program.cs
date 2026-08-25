using ExercicioFixacaoHerancaEPolimorfismo.Entities;
using System.Globalization;

namespace ExercicioFixacaoHerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Product> list = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char cui = char.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                
                if (cui == 'c')
                {
                    list.Add(new Product(name, price));
                    Console.WriteLine();
                }
                else if(cui == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                    Console.WriteLine();
                }
                else if(cui == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);

                    list.Add(new UsedProduct(name, price, manufactureDate));
                    Console.WriteLine();
                }
            }
                Console.WriteLine();
                Console.WriteLine("PRICE TAGS:");

                foreach (Product item in list)
                {
                    Console.WriteLine(item.PriceTag());
                }
        }
    }
}
