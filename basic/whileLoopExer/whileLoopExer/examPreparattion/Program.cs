using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPreparattion
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitGrades = int.Parse(Console.ReadLine());
            string examName = Console.ReadLine();
            bool isTired = false;
            int badGrade = 0;
            double sumGrade = 0;
            int problemCount = 0;
            string lastProblem = " ";
            while(examName != "Enough")
            {
                lastProblem = examName;
                int grade = int.Parse(Console.ReadLine());
                sumGrade = sumGrade + grade;
              
                if (grade <= 4)
                {
                    badGrade = badGrade + 1;
                }
                
                if (badGrade >= limitGrades)
                {
                    isTired = true;
                    break;
                }
                problemCount = problemCount + 1;
                examName = Console.ReadLine();
            }

            double averageScore = sumGrade / problemCount;

            if (isTired)
            {
                Console.WriteLine($"You need a break, {badGrade} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore,0:F2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }


        }
    }
}
