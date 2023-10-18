using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterOfTwoValues
{
    class Program
    {
        private static void getMax(long n1 , long n2)
        {
            if(n1 >= n2)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }
        private static void getMax(char n1, char n2)
        {
            if ((int)n1 > (int)n2)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }

        private static void getMax(string n1, string n2)
        {
            int firstSum = 0;
            int secondSum = 0;

            foreach (char item in n1)
            {
                firstSum = firstSum + (int)item;
            }
            foreach (char item in n2)
            {
                secondSum = secondSum + (int)item;
            }



            if (firstSum > secondSum)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }


        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            
            if(type == "int")
            {
                long first = long.Parse(firstInput);
                long second = long.Parse(secondInput);
                getMax(first, second);
            }
            else if(type == "char")
            {
                char first = char.Parse(firstInput);
                char second = char.Parse(secondInput);
                getMax(first, second);
            }
            else if(type == "string")
            {


                string first = firstInput;
                string second = secondInput;

                
                getMax(first, second);
            }





            

        }
    }
}
