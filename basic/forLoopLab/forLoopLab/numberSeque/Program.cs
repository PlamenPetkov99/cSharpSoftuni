using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSeque
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int minNum = Int32.MaxValue;
            int maxNum = Int32.MinValue;

            for (int i = 0; i < iterations; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }
                
                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
                
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");


        }
    }
}
