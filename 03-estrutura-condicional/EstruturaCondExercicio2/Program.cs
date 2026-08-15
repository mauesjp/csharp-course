namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um numero inteiro:");
            int N = int.Parse(Console.ReadLine());

            if(N % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
