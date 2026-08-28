namespace ExercicioSet.Entities
{
    internal class Student
    {
        public int Enrollment { get; set; }

        public Student(int enrollment)
        {
            Enrollment = enrollment;
        }

        public override int GetHashCode()
        {
            return Enrollment.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is not Student other)
            {
                return false;
            }

            return Enrollment == other.Enrollment;
        }
    }
}
