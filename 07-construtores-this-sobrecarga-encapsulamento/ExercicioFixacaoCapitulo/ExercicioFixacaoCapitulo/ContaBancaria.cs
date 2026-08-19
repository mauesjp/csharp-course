using System.Globalization;

namespace ExercicioFixacaoCapitulo {
    internal class ContaBancaria {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } = 0;
        public static double Taxa { get; private set; } = 5.00;

        public ContaBancaria(int conta, string nome) {
            Conta = conta;
            Titular = nome;
        }

        public void Depositar(double valor) {

            Saldo += valor;
        }

        public void Sacar(double valorSaque) {

            Saldo -= (valorSaque + Taxa);
        }

        public override string ToString() {
            return $"Conta {Conta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        
    }
}
