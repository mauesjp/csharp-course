using Exercicio3Metodos;
using System.Globalization;

namespace exMetodos {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();

            Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2",CultureInfo.InvariantCulture)}");

            if (aluno.VerificarAprovacao()) {
                Console.WriteLine("APROVADO");
            }
            else {

                double restante = aluno.Restante();
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM: {restante.ToString("F2",CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}