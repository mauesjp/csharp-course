using ExercicioFixacaoLinq.Entities;
using System.Globalization;

namespace ExercicioFixacaoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(',');
                    string name = vet[0];
                    string email = vet[1];
                    double salary = double.Parse(vet[2],CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            var sl = employees.Where(e => e.Salary > s).OrderBy(e => e.Email).Select(e => e.Email);

            Console.WriteLine($"Email of people whose salary is more than {s.ToString("F2",CultureInfo.InvariantCulture)}:");
            foreach (var email in sl)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();

            var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2",CultureInfo.InvariantCulture)} ");
        }
    }
}
