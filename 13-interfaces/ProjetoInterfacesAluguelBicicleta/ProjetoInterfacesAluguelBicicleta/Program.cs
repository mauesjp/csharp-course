using ProjetoInterfacesAluguelBicicleta.Entities;
using System.Globalization;
using ProjetoInterfacesAluguelBicicleta.Services;

namespace ProjetoInterfacesAluguelBicicleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do aluguel de bicicleta:");
            Console.Write("Número do aluguel: ");
            int numeroAluguel = int.Parse(Console.ReadLine());
            Console.Write("Cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Data e hora de início: ");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Quantidade de horas: ");
            int horasContratadas = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Aluguel aluguel = new Aluguel(numeroAluguel, nomeCliente, dataInicio, horasContratadas, new Bicicleta(valorHora));
            ServicoAluguel servicoAluguel = new ServicoAluguel(new ServicoEcoTaxa());

            servicoAluguel.ProcessarAluguel(aluguel);

            Console.WriteLine(aluguel);
            
        }
    }
}
