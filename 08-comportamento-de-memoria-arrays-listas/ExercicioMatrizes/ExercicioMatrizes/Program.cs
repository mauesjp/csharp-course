namespace ExercicioMatrizes {
    class Program {
        static void Main(string[] args) {

            string[] ij = Console.ReadLine().Split(' ');

            int m = int.Parse(ij[0]);
            int n = int.Parse(ij[1]);

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {

                    if (mat[i, j] == x) {
                        Console.WriteLine($"Posição: {i}, {j}");


                        if (j - 1 >= 0) {
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                        }

                        if (i - 1 >= 0) {
                            Console.WriteLine($"Acima: {mat[i - 1, j]}");
                        }

                        if (j + 1 < n) {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }

                        if (i + 1 < m) {
                            Console.WriteLine($"Abaixo: {mat[i + 1, j]}");
                        }

                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
