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
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for(int i = start; i <= end; i++)
            {
                string currentNum = i.ToString();
                for(int j = 0; j < currentNum.Length; j++)
                {
                    if(j % 2 == 0)
                    {
                        sumEven = sumEven + currentNum[j];
                    }
                    else
                    {
                        sumOdd = sumOdd + currentNum[j];
                    }

                }
                if(sumOdd == sumEven)
                {
                    Console.Write(i + " ");
                }
                sumOdd = 0;
                sumEven = 0;


            }




        }
    }
}
