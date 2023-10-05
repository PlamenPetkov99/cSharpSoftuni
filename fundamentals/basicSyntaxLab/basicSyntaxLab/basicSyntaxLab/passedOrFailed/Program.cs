using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }
            else
            {
                Console.WriteLine("Passed!");
            }

        }
    }
}
