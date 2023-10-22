using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumAdjacentEqualNumbers
{
    class Program
    {
        //3 3 6 1
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.Remove(numbers[i + 1]);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));




        }
    }
}
