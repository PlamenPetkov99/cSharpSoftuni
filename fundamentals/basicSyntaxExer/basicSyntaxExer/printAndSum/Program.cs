using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            string numbers = "";

            for (int i = start; i <= end; i++)
            {
                numbers = numbers + " " + i;
                sum = sum + i;
            }

            Console.WriteLine(numbers);
            Console.WriteLine($"Sum: {sum}");
            
        }
    }
}
