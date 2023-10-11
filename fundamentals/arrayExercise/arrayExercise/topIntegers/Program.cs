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

            

            for (int i = 0; i < array.Length; i++)
            {
                bool isValid = true;
                for (int j = i+1; j <= array.Length-1; j++)
                {
                    int firstNumber = array[i];
                    int secondNumber = array[j];

                    if(firstNumber > secondNumber)
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                }

                if(isValid || i == array.Length - 1)
                {
                    Console.Write($"{array[i]} ");
                }

                
            }

            foreach (var item in topIntegers)
            {
               
                
                    //Console.Write($"{item} ");
                
            }

        }
    }
}
