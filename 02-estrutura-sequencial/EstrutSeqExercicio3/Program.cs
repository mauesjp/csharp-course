
namespace exercicioEstrSeq {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o valor inteiro A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor inteiro B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor inteiro C:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor inteiro D:");
            int d = int.Parse(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine($"DIFERENÇA = {diferenca}");
        }
    }
}
