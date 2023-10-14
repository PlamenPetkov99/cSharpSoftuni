using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fullArray = Console.ReadLine().Split().ToArray();
            int bestCounter = int.MinValue;
            int counter = 1;
            string bestNumber = "";
            string lastNumber = "";

            for (int i = 0; i < fullArray.Length; i++)
            {
                string currentNumber = fullArray[i];

                if(currentNumber == lastNumber)
                {
                    counter += 1;
                }
                else
                {
                    counter = 1;
                }
                
                if(counter > bestCounter || i == 0)
                {
                    bestCounter = counter;
                    bestNumber = currentNumber;
                }

                lastNumber = currentNumber;

            }

            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write($"{bestNumber} ");
            }
            


        }
    }
}
