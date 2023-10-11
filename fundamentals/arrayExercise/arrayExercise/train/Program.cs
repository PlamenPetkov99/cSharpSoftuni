using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] waggons = new int[n];
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
                int currentPeople = int.Parse(Console.ReadLine());
                sum += currentPeople;
                waggons[i] = currentPeople;

            }
            foreach (var people in waggons)
            {
                Console.Write($"{people} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);


        }
    }
}
