using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startingArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while(startingArray.Length > 1)
            {
                int[] condensed = new int[startingArray.Length-1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = startingArray[i] + startingArray[i + 1];
                }

                
                



                startingArray = condensed;
            }

            Console.WriteLine(startingArray[0]);



        }
    }
}
