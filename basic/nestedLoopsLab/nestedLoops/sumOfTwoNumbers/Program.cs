using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool combinationFound = false;


            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int result = i + j;
                    combinationCounter = combinationCounter + 1;
                    if(result == magicNumber)
                    {
                        combinationFound = true;
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNumber})");
                        break;
                    }
                    
                }
                if (combinationFound)
                {
                    break;
                }
                
            }

            if (combinationFound == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }


            







        }
    }
}
