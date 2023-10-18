using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestOfThreeNumbers
{
    class Program
    {

        private static void Getmin(int n1 , int n2 , int n3)
        {
            int[] Arr = { n1, n2, n3 };

            Console.WriteLine(Arr.Min());
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Getmin(n1, n2, n3);


        }
    }
}
