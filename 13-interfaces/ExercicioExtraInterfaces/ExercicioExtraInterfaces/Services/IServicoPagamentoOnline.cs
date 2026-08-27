namespace ExercicioExtraInterfaces.Services
{
    interface IServicoPagamentoOnline
    {
        double JurosSimples(double valorParcela, int nParcela);
        double TaxaPagamento(double valorParcela);
    }
}
