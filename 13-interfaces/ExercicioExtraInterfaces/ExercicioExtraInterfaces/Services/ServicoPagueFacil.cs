namespace ExercicioExtraInterfaces.Services
{
    internal class ServicoPagueFacil : IServicoPagamentoOnline
    {
        private const double jurosSimples = 0.015;
        private const double taxaPagamento = 0.03;

        public double JurosSimples(double valorParcela, int nParcela)
        {
            return valorParcela * jurosSimples * nParcela;
        }

        public double TaxaPagamento(double valorParcela)
        {
            return valorParcela * taxaPagamento;
        }
    }
}
