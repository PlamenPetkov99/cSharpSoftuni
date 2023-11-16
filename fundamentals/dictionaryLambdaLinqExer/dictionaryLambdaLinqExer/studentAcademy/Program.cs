using System.Xml.Linq;

namespace studentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<decimal>> studentAndGrade = new Dictionary<string,List<decimal>>();
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!studentAndGrade.ContainsKey(studentName))
                {
                    studentAndGrade[studentName] = new List<decimal>();
                    studentAndGrade[studentName].Add(grade);
                }
                else
                {
                    studentAndGrade[studentName].Add(grade);
                }
                

            }

            Dictionary<string, decimal> studentsWithAverageGrade = new Dictionary<string, decimal>();

            foreach (KeyValuePair<string , List<decimal>> kvp in studentAndGrade)
            {
                decimal averageGrade = default;
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    averageGrade = averageGrade + kvp.Value[i];
                }
                averageGrade = averageGrade / kvp.Value.Count;
                studentsWithAverageGrade[kvp.Key] = averageGrade;

            }


            //keep the students with an average grade higher than or equal to 4.50

            studentsWithAverageGrade = studentsWithAverageGrade.Where(x=> x.Value >= 4.50m).ToDictionary(x=> x.Key,x=>x.Value);

            foreach (KeyValuePair<string,decimal> kvp in studentsWithAverageGrade)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value,0:F2}");
            }

        }
    }
}