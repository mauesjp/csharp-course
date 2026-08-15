namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira dois números inteiros:");
            string[] v = Console.ReadLine().Split(' ');

            int A = int.Parse(v[0]);
            int B = int.Parse(v[1]);

            if(A % B == 0 || B % A == 0) {
                Console.WriteLine("SAO MULTIPLOS");
            }
            else {
                Console.WriteLine("NAO SAO MULTIPLOS");
            }
        }
    }
}
