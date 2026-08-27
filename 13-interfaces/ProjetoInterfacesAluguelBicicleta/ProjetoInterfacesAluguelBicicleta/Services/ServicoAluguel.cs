using ProjetoInterfacesAluguelBicicleta.Entities;

namespace ProjetoInterfacesAluguelBicicleta.Services
{
    internal class ServicoAluguel
    {
        private readonly IServicoCobranca _servicoCobranca;

        public ServicoAluguel(IServicoCobranca servicoCobranca)
        {
            _servicoCobranca = servicoCobranca;
        }

        public void ProcessarAluguel(Aluguel aluguel)
        {

            double valorBase = aluguel.ValorBase();

            aluguel.TaxaAmbiental = _servicoCobranca.TaxaAmbiental(valorBase);
            aluguel.TaxaUso = _servicoCobranca.TaxaUso(valorBase, aluguel.HorasContratadas);
            aluguel.ValorTotal = valorBase + aluguel.TaxaAmbiental + aluguel.TaxaUso;


        }
    }
}
