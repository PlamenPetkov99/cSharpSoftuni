using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           


            
            for (int i = 1; i <= n; i++)//numbers from 1 to n
            {
                int sum = 0;
                int number = i; // current Number
                string numberAsString = number.ToString();// convert the number as string

                for (int j = 0; j < numberAsString.Length; j++)
                {
                    int currentNumber = (int)char.GetNumericValue(numberAsString[j]);
                    sum = sum + currentNumber;

                    

                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                if (isSpecial)
                {
                    Console.WriteLine($"{number} -> True");
                }
                else
                {
                    Console.WriteLine($"{number} -> False");
                }
            }



        }
    }
}
