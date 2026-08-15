namespace estrFor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um número:");
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= N; i++) {

                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
