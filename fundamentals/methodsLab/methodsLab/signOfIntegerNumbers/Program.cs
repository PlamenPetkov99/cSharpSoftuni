﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signOfIntegerNumbers
{
    class Program
    {
        private static void printer(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }



        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printer(n);



        }
    }
}
