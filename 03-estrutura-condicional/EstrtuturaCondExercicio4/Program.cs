
namespace estrCond {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Insira horario de inicio e fim do jogo:");
            string[] s = Console.ReadLine().Split(' ');

            int hInicio = int.Parse(s[0]);
            int hFinal = int.Parse(s[1]);
            int duracao;

            if(hFinal > hInicio) {

                duracao = hFinal - hInicio;
            }
            else {
                duracao = 24 - hInicio + hFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}