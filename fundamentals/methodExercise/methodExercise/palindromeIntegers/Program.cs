using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeIntegers
{
    class Program
    {

        private static bool Palindromecheck(string number)
        {
            string currentNumber = number;
            string reversedNumber = "";
            for (int i = currentNumber.Length - 1; i >= 0; i--)
            {
                reversedNumber += currentNumber[i];
            }
            if(currentNumber == reversedNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool isPali = default;
            string command = "";
            while((command = Console.ReadLine()) != "END")
            {
                isPali = Palindromecheck(command);
                Console.WriteLine(isPali);
            }

        }
    }
}
