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
            int limit = int.Parse(Console.ReadLine());
            int sum = 0;

            while(sum < limit)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
