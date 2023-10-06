using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberDigits = Console.ReadLine();
            int sum = 0;

            foreach(char digit in numberDigits)
            {
                int currentDigit = (int)char.GetNumericValue(digit);
                sum += currentDigit;
            }

            Console.WriteLine(sum);


        }
    }
}
