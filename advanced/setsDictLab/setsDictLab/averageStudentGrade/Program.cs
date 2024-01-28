namespace averageStudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> nameAndGrades = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] nameGrade = Console.ReadLine().Split().ToArray();
                string name = nameGrade[0];
                decimal grade = decimal.Parse(nameGrade[1]);

                if (!nameAndGrades.ContainsKey(name))
                {
                    nameAndGrades[name] = new List<decimal>();
                    nameAndGrades[name].Add(grade);
                }
                else 
                {
                    nameAndGrades[name].Add(grade);
                }

                

            }


            Dictionary<string, decimal> nameAvgGrade = new Dictionary<string, decimal>();

            foreach (KeyValuePair<string,List<decimal>> kvp in nameAndGrades)
            {
                decimal averageGrade = 0;
                int numberOfGrades = kvp.Value.Count;
                foreach (decimal grade in kvp.Value)
                {
                    averageGrade += grade;
                }
                averageGrade /= numberOfGrades;

                nameAvgGrade[kvp.Key] = averageGrade;
            }

            //John -> 5.20 3.20 (avg: 4.20)

            foreach (KeyValuePair<string,List<decimal>> kvp in nameAndGrades)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach(decimal grade in kvp.Value)
                {
                    Console.Write($"{grade,0:F2} ");
                }
                Console.WriteLine($"(avg: {nameAvgGrade[kvp.Key],0:F2})");
            }

        }
    }
}
