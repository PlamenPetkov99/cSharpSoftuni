using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateRectangleArea
{
    class Program
    {
        private static int Area(int a , int b)
        {

            return a * b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = Area(a,b);
            Console.WriteLine(sum);


        }
    }
}
