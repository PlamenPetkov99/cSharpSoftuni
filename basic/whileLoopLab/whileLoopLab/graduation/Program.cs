using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int failed = 0;
            double sumFromGrades = 0;
            while (grade <= 12)
            {
                double yeargrade = double.Parse(Console.ReadLine());
                if (yeargrade < 4.00)
                {
                    failed = failed + 1;
                    if(failed == 2)
                    {
                        break;
                    }
                    continue;
                }
                else
                {
                    grade = grade + 1;
                    sumFromGrades = sumFromGrades + yeargrade;
                }

            }
            double averageGrade = sumFromGrades / 12;

            if (failed >= 2)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade,0:F2}");
            }


        }
    }
}
