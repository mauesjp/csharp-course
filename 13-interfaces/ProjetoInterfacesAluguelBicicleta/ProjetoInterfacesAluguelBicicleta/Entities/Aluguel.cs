using System.Globalization;
using System.Text;

namespace ProjetoInterfacesAluguelBicicleta.Entities
{
    internal class Aluguel
    {
        public int NumeroAluguel { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataInicio { get; private set; }
        public int HorasContratadas { get; set; }
        public Bicicleta Bicicleta { get; set; }
        public double TaxaAmbiental { get; set; }
        public double TaxaUso { get; set; }
        public double ValorTotal { get; set; }

        public Aluguel(int numeroAluguel, string nomeCliente, DateTime dataInicio, int horasContratadas, Bicicleta bicicleta)
        {
            NumeroAluguel = numeroAluguel;
            NomeCliente = nomeCliente;
            DataInicio = dataInicio;
            HorasContratadas = horasContratadas;
            Bicicleta = bicicleta;
        }

        public double ValorBase()
        {
            return HorasContratadas * Bicicleta.ValorHora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Aluguel Nº{NumeroAluguel}");
            sb.AppendLine($"Cliente: {NomeCliente}");
            sb.AppendLine($"Data de Inicio: {DataInicio.ToString("dd/MM/yyyy HH:mm")}");
            sb.AppendLine($"Data de Devolução: {DataInicio.AddHours((double)HorasContratadas).ToString("dd/MM/yyyy HH:mm")}");
            sb.AppendLine($"Bicicleta: {Bicicleta.Id}");
            sb.AppendLine();
            sb.AppendLine($"Valor base: R${ValorBase().ToString("F2",CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Taxa ambiental: R${TaxaAmbiental.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Taxa de uso: R${TaxaUso.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Valor final: R${ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
