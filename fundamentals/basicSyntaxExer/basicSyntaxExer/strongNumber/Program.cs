using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberInString = number.ToString();
            int facSum = 0;
            int currSum = 0;
            int fact = 1;
            

            for (int i = 0; i < numberInString.Length; i++)
            {
                char curNum = numberInString[i];
                double currentNumber = char.GetNumericValue(curNum);
                int currentNumberInt = Convert.ToInt32(currentNumber);
                
                for (int j = 1; j <= currentNumberInt; j++)
                {
                    fact = fact * j;
                }
                currSum = currSum + fact;
                fact = 1;

            }
            if(currSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
