namespace estrFor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira o numero de vezes que será executado:");
            int N = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;


            for(int i = 1; i <= N; i++) {

                Console.WriteLine("Insira um valor inteiro:");
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20) {
                    dentro++;
                }
                else
                    fora++;
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}