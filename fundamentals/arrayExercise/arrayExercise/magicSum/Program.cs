using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNumber = array[j];

                    if(currentNumber + secondNumber == magicNum)
                    {
                        Console.WriteLine($"{currentNumber} {secondNumber}");

                    }

                }

            }
        
        }
    }
}
