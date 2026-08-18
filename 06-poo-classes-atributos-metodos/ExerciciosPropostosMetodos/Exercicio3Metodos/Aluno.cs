namespace Exercicio3Metodos {
    internal class Aluno {

        public string Nome;
        public double N1, N2, N3;
        


        public double NotaFinal() {
            return N1 + N2 + N3;
          
        }

        public double Restante() {
            return 60.00 - NotaFinal();
        }

        public bool VerificarAprovacao() {
            return NotaFinal() >= 60.00;
        }

    }
}
