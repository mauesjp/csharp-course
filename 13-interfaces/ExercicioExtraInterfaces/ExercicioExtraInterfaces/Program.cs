using ExercicioExtraInterfaces.Entities;
using ExercicioExtraInterfaces.Services;
using System.Globalization;

namespace ExercicioExtraInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados da compra:");
            Console.Write("Numero: ");
            int numeroCompra = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataCompra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor da compra: ");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Numero de parcelas: ");
            int nParcelas = int.Parse(Console.ReadLine());

            Compra compra = new Compra(numeroCompra, dataCompra, valorCompra);

            ServicoCompra servicoCompra = new ServicoCompra(new ServicoPagueFacil());
            servicoCompra.ProcessarCompra(compra, nParcelas);

            Console.WriteLine();
            Console.WriteLine("Parcelas:");
            foreach (Parcela parcela in compra.Parcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}
