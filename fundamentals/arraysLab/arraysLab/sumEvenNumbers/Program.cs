using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            
            foreach(int num in allNumbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }

            }

            Console.WriteLine(sum);

        }
    }
}
