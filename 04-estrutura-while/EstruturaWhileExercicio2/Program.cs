namespace estrWhile {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Insira as coordenadas:");
            string[] coord = Console.ReadLine().Split(' ');

            int X = int.Parse(coord[0]);
            int Y = int.Parse(coord[1]);

            while(X != 0 && Y != 0) {
            // Vou criar uma função 'Quadrante' somente para colocar em prática os ensinamentos de função do curso
                string quad = Quadrante(X, Y);
                Console.WriteLine(quad);
                Console.WriteLine("Insira outras coordenadas:");
                coord = Console.ReadLine().Split(' ');

                X = int.Parse(coord[0]);
                Y = int.Parse(coord[1]);
            }

        
        }
        static string Quadrante(int x, int y) {
            string q;

            if(x > 0 && y > 0) {
                q = "Primeiro";

                return q;
            }
            else if(x < 0 && y > 0) {
                q = "Segundo";

                return q;
            }
            else if(x < 0 && y < 0) {
                q = "Terceiro";

                return q;
            }
            else {
                q = "Quarto";

                return q;
            }
        }
    }
}