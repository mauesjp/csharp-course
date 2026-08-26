using System.Globalization;

namespace ProjetoInterfaces.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)} - {Amount.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
