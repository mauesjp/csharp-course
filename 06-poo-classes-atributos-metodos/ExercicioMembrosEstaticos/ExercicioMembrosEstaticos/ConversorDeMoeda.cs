namespace ExercicioMembrosEstaticos {
    internal class ConversorDeMoeda {

        public static double Iof = 0.06;

        public static double Conversao(double cotacao, double quantidade) {
            double total = quantidade * cotacao;
            return total + total * Iof;
        }
    }
}
