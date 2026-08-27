using ExercicioExtraInterfaces.Entities;

namespace ExercicioExtraInterfaces.Services
{
    internal class ServicoCompra
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoCompra(IServicoPagamentoOnline servicoPagamentoOnline)
        {

            _servicoPagamentoOnline = servicoPagamentoOnline;

        }

        public void ProcessarCompra(Compra compra, int nParcelas)
        {
            double parcela = compra.ValorCompra / nParcelas;

            for(int i = 1; i <= nParcelas; i++)
            {
                DateTime data = compra.DataCompra.AddMonths(i);
                double parcelaAtualizada = parcela + _servicoPagamentoOnline.JurosSimples(parcela, i);
                double parcelaTotal = parcelaAtualizada + _servicoPagamentoOnline.TaxaPagamento(parcelaAtualizada);

                compra.Parcelas.Add(new Parcela(data, parcelaTotal));
            }
        }
    }
}
