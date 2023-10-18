using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculations
{
    class Program
    {
        private static void add(int n1 , int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        private static void multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
        private static void subtract(int n1, int n2)
        {
            Console.WriteLine(n1 % n2);
        }
        private static void divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
        static void Main(string[] args)
        {
            string operation = Console.ReadLine(); //"add", "multiply", "subtract", "divide"
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    add(a, b);
                    break;
                case "multiply":
                    multiply(a, b);
                    break;
                case "subtract":
                    subtract(a, b);
                    break;
                case "divide":
                    divide(a, b);
                    break;
            }

        }
    }
}
