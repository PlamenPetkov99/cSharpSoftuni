using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //{theInteger} X {times} = {product}

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;

                Console.WriteLine($"{number} X {i} = {result}");
            }

        }
    }
}
