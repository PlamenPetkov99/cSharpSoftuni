using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach(double number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }


        }
    }
}
