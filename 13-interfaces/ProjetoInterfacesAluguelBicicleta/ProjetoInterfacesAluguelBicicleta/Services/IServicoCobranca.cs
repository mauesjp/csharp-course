namespace ProjetoInterfacesAluguelBicicleta.Services
{
    interface IServicoCobranca
    {
        double TaxaAmbiental(double valorBase);
        double TaxaUso(double valorBase, int horasContratadas);
    }
}
