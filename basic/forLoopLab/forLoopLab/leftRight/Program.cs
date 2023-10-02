using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < iteration; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                leftSum = leftSum + currentNumber;
            }
            for (int i = 0; i < iteration; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                rightSum = rightSum + currentNumber;
            }
            int diff = Math.Abs(rightSum - leftSum);
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
