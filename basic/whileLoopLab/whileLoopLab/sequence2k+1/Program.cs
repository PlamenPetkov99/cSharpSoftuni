using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            while (currentNumber <= limit)
            {
                Console.WriteLine(currentNumber);
                currentNumber = (currentNumber * 2) + 1;


            }



        }
    }
}
