using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathPower
{
    class Program
    {

        private static int getPower(double n1, int n2)
        {
            double result = 1;
            for (int i = 0; i < n2; i++)
            {
                result = result * n1;
            }
            return (int)result;
        }
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumer = int.Parse(Console.ReadLine());
            int result = getPower(baseNumber, powerNumer);
            Console.WriteLine(result);
        }
    }
}
