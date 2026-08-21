namespace ExercicioExtraMatrizes {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com o numero de linhas:");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero de colunas:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com os valores da matriz:");

            int[,] matriz = new int[L, C];

            for(int linhas = 0; linhas < L; linhas++) {
                string[] valores = Console.ReadLine().Split(' ');

                for(int colunas = 0; colunas < C; colunas++) {

                    matriz[linhas, colunas] = int.Parse(valores[colunas]);
                }
            }

            Console.WriteLine();
            Console.Write("Insira um numero da matriz para receber os dados: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("================RESULTADOS================");

            for(int i = 0; i < L; i++) {
                for(int j = 0; j < C; j++) {
                    if (matriz[i, j] == numero) {

                        int soma = 0;

                        Console.WriteLine($"Posição: {i}, {j}");

                        //verificar vizinho da esquerda
                        if(j - 1 >= 0) {
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                            soma += matriz[i, j - 1];
                        }

                        //verificar vizinho de cima
                        if(i - 1 >= 0) {
                            Console.WriteLine($"Acima: {matriz[i - 1, j]}");
                            soma += matriz[i - 1, j];
                        }

                        //verificar vizinho da direita
                        if(j + 1 < C) {
                            Console.WriteLine($"Direita: {matriz[i, j + 1]}");
                            soma += matriz[i, j + 1];
                        }

                        //verificar vizinho de baixo
                        if(i + 1 < L) {
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                            soma += matriz[i + 1, j];
                        }

                        Console.WriteLine($"Soma dos vizinhos: {soma}");
                    }
                }
            }



        }
    }
}
