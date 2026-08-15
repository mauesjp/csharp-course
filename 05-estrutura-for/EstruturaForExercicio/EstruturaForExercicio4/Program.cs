using System.Globalization;

namespace estrFor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o numero de vezes:");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++) {

                Console.WriteLine("Insira dois números:");
                string[] numeros = Console.ReadLine().Split(' ');

                int valor1 = int.Parse(numeros[0]);
                int valor2 = int.Parse(numeros[1]);

                if(valor2 == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double divisao = (double)valor1 / valor2 ;

                    Console.WriteLine(divisao.ToString("F1",CultureInfo.InvariantCulture));
                }
                    
            }
        }
    }
}
