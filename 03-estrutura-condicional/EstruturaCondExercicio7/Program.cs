using System.Globalization;

namespace estrCond {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira as coordenadas X e Y:");
            string[] xy = Console.ReadLine().Split(' ');

            double X = double.Parse(xy[0],CultureInfo.InvariantCulture);
            double Y = double.Parse(xy[1],CultureInfo.InvariantCulture);

            if(X == 0.0 && Y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if(X == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if(Y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if(X > 0 && Y > 0) {
                Console.WriteLine("Q1");
            }
            else if(X < 0 && Y > 0) {
                Console.WriteLine("Q2");
            }
            else if(X < 0 && Y < 0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}
