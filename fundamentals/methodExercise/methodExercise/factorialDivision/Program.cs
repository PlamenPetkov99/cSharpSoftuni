using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialDivision
{
    class Program
    {
        private static int Getfactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int n1Factorial = Getfactorial(n1);
            int n2Factorial = Getfactorial(n2);

            double result = (double)n1Factorial / (double)n2Factorial;
            Console.WriteLine(n1Factorial);
            Console.WriteLine(n2Factorial);
            Console.WriteLine($"{result,0:F2}");

        }
    }
}
