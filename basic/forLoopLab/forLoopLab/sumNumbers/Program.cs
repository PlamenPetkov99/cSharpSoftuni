using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber;
            }

            Console.WriteLine(sum)
        }
    }
}
