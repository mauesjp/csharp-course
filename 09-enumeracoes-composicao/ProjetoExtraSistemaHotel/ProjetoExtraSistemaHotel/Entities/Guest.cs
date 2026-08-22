using System.Globalization;

namespace ProjetoExtraSistemaHotel.Entities
{
    internal class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Guest()
        {

        }

        public Guest(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name}, ({BirthDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)}) - {Email}";
        }
    }
}
