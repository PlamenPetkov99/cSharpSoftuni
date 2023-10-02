using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int printedNum = 1;

            while (printedNum <= number)
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < printedNum; j++)
                    {
                        Console.Write(printedNum + " ");
                    }
                    Console.WriteLine();
                }


                printedNum++;
            }


        }
    }
}
