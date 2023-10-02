using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for(int i = 0; i < iteration; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven = sumEven + currentNumber;
                }
                else if(i % 2 != 0)
                {
                    sumOdd = sumOdd + currentNumber;
                }
            }
            
            int diff = Math.Abs(sumEven - sumOdd);

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }





        }
    }
}
