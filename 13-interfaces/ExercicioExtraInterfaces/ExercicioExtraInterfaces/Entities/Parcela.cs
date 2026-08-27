using System.Globalization;

namespace ExercicioExtraInterfaces.Entities
{
    internal class Parcela
    {
        public DateTime Vencimento { get; set; }
        public double ValorParcela { get; set; }

    public Parcela(DateTime vencimento, double valorParcela )
        {
            Vencimento = vencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"{Vencimento.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)} - R${ValorParcela.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
