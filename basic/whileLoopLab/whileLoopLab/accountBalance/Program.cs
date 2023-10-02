using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting String to Double
            //String word = "123.9873242342342342342342342341";
            //Double number = Double.Parse(word);
            //Console.WriteLine(number);
            
            string command = Console.ReadLine();
            double sum = 0;
            while(command != "NoMoreMoney")
            {
                double currentNumber = double.Parse(command);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum = sum + currentNumber;
                Console.WriteLine($"Increase: {currentNumber,0:F2}");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum,0:F2}");


        }
    }
}
