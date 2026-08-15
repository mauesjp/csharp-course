namespace estrWhile {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a senha:");
            int senha = int.Parse(Console.ReadLine());

            int senhacorreta = 2002;

            while(senha != senhacorreta) {
                Console.WriteLine("Senha Invalida!");
                Console.Write("Digite a senha novamente:");
                senha = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso Permitido!");
        }
    }
}
