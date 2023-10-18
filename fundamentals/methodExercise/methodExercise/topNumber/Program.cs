using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topNumber
{
    class Program
    {

        private static bool Firstrule(int number) //•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
        {
            int result = 0;
            string numberAsString = number.ToString();
            foreach (char letter in numberAsString)
            {
                int currentNumber = (int)char.GetNumericValue(letter);
                result = result + currentNumber;
            }
            if(result % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Secondrule(int number)//•	Holds at least one odd digit, e.g. 232, 707, 87578
        {
            string numberAsString = number.ToString();
            foreach (char letter in numberAsString)
            {
                int currentNumber = (int)char.GetNumericValue(letter);
                if(currentNumber % 2 != 0)
                {
                    return true;
                }
            }
            return false;

        }


        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= iterations; i++)
            {


                if (Firstrule(i) && Secondrule(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
