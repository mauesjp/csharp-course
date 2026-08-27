namespace ProjetoInterfacesAluguelBicicleta.Services
{
    internal class ServicoEcoTaxa : IServicoCobranca
    {
        private const double PercentualTaxaAmbiental = 0.04;
        private const double PercentualTaxaUsoReduzida = 0.02;
        private const double PercentualTaxaUsoNormal = 0.05;

        public double TaxaAmbiental(double valorBase)
        {
            return valorBase * PercentualTaxaAmbiental;
        }

        public double TaxaUso(double valorBase, int horasContratadas)
        {
            if (horasContratadas <= 5)
            {

                return valorBase * PercentualTaxaUsoReduzida;
            }
            else
            {

                return valorBase * PercentualTaxaUsoNormal;
            }
        }
    }
}
