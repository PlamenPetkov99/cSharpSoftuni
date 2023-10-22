using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listManipulationBasics
{
    class Program
    {
        private static bool Contain(List<int> list , int value)
        {

            if (list.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void PrintEven(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintOdd(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    Console.Write(list[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void Filtered(List<int> list , string condition,int number)
        {
            switch (condition)
            {
                case "<":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(list[i] < number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] >= number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= number)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    Console.WriteLine();
                    break;

            }

        }

        private static void GetSum(List<int> list)
        {
            Console.WriteLine(list.Sum());
        }
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commandAndValues = input.Split().ToList();
                string command = commandAndValues[0];
                if(commandAndValues.Count > 1)
                {
                string value1 = commandAndValues[1]; //condition in filter method
                    switch (command)
                    {
                        case "Contains":
                            bool isTrue = Contain(numbers, int.Parse(value1));
                            if (isTrue)
                            {
                                Console.WriteLine("Yes");
                            }
                            else
                            {
                                Console.WriteLine("No such number");
                            }
                            break;
                        case "Filter":
                            int value2 = int.Parse(commandAndValues[2]); //value
                            Filtered(numbers, value1, value2);
                            break;
                    }
                }
                switch (command)
                {

                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        GetSum(numbers);
                        break;
                }
            }

            


        }
    }
}
