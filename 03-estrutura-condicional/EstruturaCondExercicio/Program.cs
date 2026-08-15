namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um número inteiro:");
            int N = int.Parse(Console.ReadLine());

            if(N >= 0) {
                Console.WriteLine("NAO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}