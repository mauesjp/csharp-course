namespace ProjetoInterfacesAluguelBicicleta.Entities
{
    internal class Bicicleta
    {
        private static int GeradorId = 0;
        public int Id { get; private set; }
        public double ValorHora { get; set; }

        public Bicicleta(double valorHora)
        {
            Id = ++GeradorId;
            ValorHora = valorHora;
        }
    }
}
