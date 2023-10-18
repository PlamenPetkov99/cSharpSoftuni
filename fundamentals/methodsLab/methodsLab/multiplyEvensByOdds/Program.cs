using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplyEvensByOdds
{
    class Program
    {
        private static int GetSumOfEvenDigits(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] == '-')
                {
                    continue;
                }
                int currentNumber = (int)char.GetNumericValue(number[i]);
                if(currentNumber % 2 == 0)
                {
                    result = result + currentNumber;
                }

            }

            return result;
        }


        private static int GetSumOfOddDigits(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-')
                {
                    continue;
                }
                int currentNumber = (int)char.GetNumericValue(number[i]);
                if (currentNumber % 2 != 0)
                {
                    result = result + currentNumber;
                }

            }

            return result;
        }

        private static void GetMultipleOfEvenAndOdds(int a , int b)
        {
            Console.WriteLine(a * b);

        }
        static void Main(string[] args)
        {
            string numberAsString = Console.ReadLine();


            int a = GetSumOfEvenDigits(numberAsString);
            int b = GetSumOfOddDigits(numberAsString);

            GetMultipleOfEvenAndOdds(a, b);




        }
    }
}
