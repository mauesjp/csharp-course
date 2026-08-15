
namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um valor inteiro:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro valor inteiro:");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
