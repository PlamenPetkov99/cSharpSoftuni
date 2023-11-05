namespace students
{
    /*
    John Smith 15 Sofia
    Peter Ivanov 14 Plovdiv
    Linda Bridge 16 Sofia
    Simon Stone 12 Varna
    end
    Sofia	
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Smith 15 Sofia //end

            string input = default;
            List<Student> list = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split().ToArray();
                Student student = new Student();
                student.firstName = tokens[0];
                student.lastName = tokens[1];
                student.age = int.Parse(tokens[2]);
                student.homeTown = tokens[3];
                list.Add(student);
                
            }
            string filterCity = Console.ReadLine();
            List<Student> resultList = list.Where(student => student.homeTown == filterCity).ToList();

            foreach (Student student in resultList)
            {
                Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
            }

        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }
    }
    
}