namespace ExercicioExtraInterfaces.Entities
{
    internal class Compra
    {
        public int NumeroCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorCompra { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Compra(int numeroCompra, DateTime dataCompra, double valorCompra)
        {
            NumeroCompra = numeroCompra;
            DataCompra = dataCompra;
            ValorCompra = valorCompra;
            Parcelas = new List<Parcela>();
        }
    }
}
