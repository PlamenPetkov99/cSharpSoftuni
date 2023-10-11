using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topIntegers = new int[array.Length];

            for (int indexCurrentNumber = 0; indexCurrentNumber < array.Length; indexCurrentNumber++)
            {
                for (int indexSumNumber = indexCurrentNumber +1; indexSumNumber < array.Length; indexSumNumber++)
                {
                    if(array[indexCurrentNumber] > array[indexSumNumber] )
                    {
                        topIntegers[indexCurrentNumber] = array[indexCurrentNumber];
                        
                    }
                    else
                    {
                        break;
                    }
                    
                }
                if(indexCurrentNumber == array.Length - 1)
                {
                    topIntegers[indexCurrentNumber] = array[array.Length - 1];
                }
            }

            Console.WriteLine(string.Join(" ",topIntegers));



        }
    }
}
