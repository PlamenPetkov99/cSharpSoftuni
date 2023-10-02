using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int maxnum = int.MinValue;
            int sum = 0;


            for(int i = 0; i < iterations; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum = sum + currentNum;

                if (maxnum < currentNum)
                {
                    maxnum = currentNum;
                }



            }
            sum = sum - maxnum;
            int diff = Math.Abs(sum - maxnum);

            if (maxnum == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxnum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }


        }
    }
}
