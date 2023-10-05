using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int countN = int.Parse(Console.ReadLine());
            int n = 0;
            int sumOfN = 0;
            while(n < countN)
            {
                if(i % 2 != 0)
                {
                    sumOfN = sumOfN + i;
                    Console.WriteLine(i);
                    n++;
                }
              
                i++;
                
                
            }

            Console.WriteLine($"Sum: {sumOfN}");


        }
    }
}
