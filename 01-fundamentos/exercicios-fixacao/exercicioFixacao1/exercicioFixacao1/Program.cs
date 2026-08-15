using System;
using System.Globalization;


namespace exercicioFixacao1 {

    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($"Produtos: {produto1}, cujo preço e ${preco1:F2}" +
                              $" {produto2}, cujo preço e ${preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero : {genero}");

            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado para 3 casaas: {medida:F3}");
            Console.WriteLine($"Separador decimal: {medida.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
