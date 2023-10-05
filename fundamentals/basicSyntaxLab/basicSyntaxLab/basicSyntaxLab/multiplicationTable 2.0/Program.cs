using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //{theInteger} X {times} = {product}

            int number = int.Parse(Console.ReadLine());
            int startingMultiplayer = int.Parse(Console.ReadLine());


            for (int i = startingMultiplayer; i <= 10; i++)
            {
                int result = number * i;

                Console.WriteLine($"{number} X {i} = {result}");
            }
            
            if(startingMultiplayer > 10)
            {
                Console.WriteLine($"{number} X {startingMultiplayer} = {number * startingMultiplayer}");
            }
        }
    }
}
