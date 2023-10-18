using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        private static void grade(double number)
        {
            if ((2.00 <= number) && (number <= 2.99))
            {
                Console.WriteLine("Fail");
            }
            else if ((3.00 <= number) && (number <= 3.49))
            {
                Console.WriteLine("Poor");
            }
            else if ((3.50 <= number) && (number <= 4.49))
            {
                Console.WriteLine("Good");
            }
            else if ((4.50 <= number) && (number <= 5.49))
            {
                Console.WriteLine("Very good");
            }
            else if ((5.50 <= number) && (number <= 6.00))
            {
                Console.WriteLine("Excellent");
            }

        }
        static void Main(string[] args)
        {   
            grade(double.Parse(Console.ReadLine()));


        }
    }
}
