using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();
            string[] commonElements = new string[secondArray.Length];

            for (int indexSecondArray = 0; indexSecondArray < secondArray.Length; indexSecondArray++)
            {
                for (int indexFirstArray = 0; indexFirstArray < firstArray.Length; indexFirstArray++)
                {
                    if(secondArray[indexSecondArray] == firstArray[indexFirstArray] )
                    {
                        commonElements[indexSecondArray] = secondArray[indexSecondArray];
                    }

                }
            }

            for (int i = 0; i < commonElements.Length; i++)
            {
                if(commonElements[i] != null)
                {
                    Console.Write(commonElements[i] + " ");
                }
            }
               

        }
    }
}
