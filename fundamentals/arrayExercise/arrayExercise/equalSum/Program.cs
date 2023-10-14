using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fullArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // [1 ,2 ,3 ,4 ,5]
            //  0  1  2  3  4 (i)
            //  1  2  3  4  5 (len)
            // 1 2 3 3

            bool isInvalid = true;
            for (int i = 0; i < fullArray.Length; i++)
            {
                int currentNumber = fullArray[i];
                int leftSum = 0;
                int rightSum = 0;

                for (int l = 0; l < i; l++)
                {
                    leftSum = leftSum + fullArray[l];
                }
                for (int r = i + 1; r < fullArray.Length; r++)
                {
                    rightSum = rightSum + fullArray[r];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isInvalid = false;
                }

            }

            if (isInvalid)
            {
                Console.WriteLine("no");
            }


        }
    }
}
