using ExercicioTratamentoExecoes.Entities.Exceptions;

namespace ExercicioTratamentoExecoes.Entities
{
    internal class Account
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int numberAccount, string holder, double balance, double withdrawLimit)
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            Balance -= amount;
        }
    }
}
