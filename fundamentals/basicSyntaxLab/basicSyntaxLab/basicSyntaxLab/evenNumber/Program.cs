using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if(number % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");

        }
    }
}
