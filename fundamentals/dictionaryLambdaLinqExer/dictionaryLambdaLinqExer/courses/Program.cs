namespace courses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = default;
            Dictionary<string,List<string>> courseWithStudens = new Dictionary<string,List<string>>();
            while((input = Console.ReadLine())!= "end") //"{courseName} : {studentName}"
            {
                string[] inputTokens = input.Split(" : ").ToArray();
                string courseName = inputTokens[0];
                string studentName = inputTokens[1];

                if(!courseWithStudens.ContainsKey(courseName))
                {
                    courseWithStudens[courseName] = new List<string>();
                    courseWithStudens[courseName].Add(studentName);
                }
                else
                {
                    courseWithStudens[courseName].Add(studentName);
                }
            }

            //"{courseName}: {registeredStudents}"
            //"-- {studentName}"

            foreach (KeyValuePair<string,List<string>> kvp in courseWithStudens)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }


        }
    }
}