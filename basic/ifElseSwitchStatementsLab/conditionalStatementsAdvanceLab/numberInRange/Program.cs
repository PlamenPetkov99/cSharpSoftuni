using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((-100 <= number) && (number <= 100) && (number != 0))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
