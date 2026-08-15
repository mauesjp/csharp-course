namespace estrFor {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira um valor inteiro:");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++) {

                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
