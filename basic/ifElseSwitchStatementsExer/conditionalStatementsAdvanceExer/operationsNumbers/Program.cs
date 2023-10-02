using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    int result = numberOne + numberTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {result} - odd");
                    }
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {result} - odd");
                    }
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {result} - odd");
                    }
                    break;
                case "%":
                
                    if (numberOne == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberTwo} by zero");
                    }
                    else if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        result = numberOne % numberTwo;
                        Console.WriteLine($"{numberOne} % {numberTwo} = {result}");
                    }
                    break;
            }
            switch (operation)
            {
                case "/":
                    if (numberOne == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberTwo} by zero");
                    }
                    else if (numberTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    else
                    {
                        double result = (double) numberOne / numberTwo;
                        Console.WriteLine($"{numberOne} / {numberTwo} = {result,0:F2}");
                    }
                    break;


            }

            
        }
    }
}
