using ExercicioSet.Entities;

namespace ExercicioSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
            //Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser.
            //Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os cursos que ele possui,
            //pois pode haver alunos repetidos em mais de um curso.
            //O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
            //Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.

            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                Student student = new Student(enrollment);

                set.Add(student);
            }

            Console.WriteLine();
            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                Student student = new Student(enrollment);

                set.Add(student);
            }

            Console.WriteLine();
            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int enrollment = int.Parse(Console.ReadLine());
                Student student = new Student(enrollment);

                set.Add(student);
            }


            Console.WriteLine($"Total Students: {set.Count}");
        }
    }
}
