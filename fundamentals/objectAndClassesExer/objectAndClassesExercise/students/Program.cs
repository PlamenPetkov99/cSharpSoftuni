namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countStudents; i++)
            {
                Student student = new Student();
                string[] input = Console.ReadLine().Split().ToArray();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = double.Parse(input[2]);
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderBy(x => x.Grade).ToList();
            sortedStudents.Reverse();

            foreach (Student item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade,0:F2}";
            //"{FirstName} {LastName}: {Grade,0:F2}"
        }
    }
}