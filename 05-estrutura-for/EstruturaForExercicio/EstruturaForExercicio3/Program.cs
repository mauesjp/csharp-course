using System.Globalization;

namespace estrFor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o numero de vezes:");
            int N = int.Parse(Console.ReadLine());
            double media;

            for(int i = 1; i <= N; i++) {
                Console.WriteLine("insira os valores: ");
                string[] vet = Console.ReadLine().Split(' ');

                double valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((valor1 * 2.0) + (valor2 * 3.0) + (valor3 * 5.0)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
