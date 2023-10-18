using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathOperations
{
    class Program
    {

        private static void Oper(int n1 , int n2 , string operation)
        {
            switch (operation)
            {
                case "/":
                    Console.WriteLine(n1 / n2);
                    break;
                case "*":
                    Console.WriteLine(n1 * n2);
                    break;
                case "+":
                    Console.WriteLine(n1 + n2);
                    break;
                case "-":
                    Console.WriteLine(n1 - n2);
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());


            Oper(n1, n2, operation);

        }
    }
}
