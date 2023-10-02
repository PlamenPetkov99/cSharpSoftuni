using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quntity = double.Parse(Console.ReadLine());
            double price = 0;
            bool isWorking = true;
            bool isValidDay = true;
            bool isValidFruit = true;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    isWorking = true; break;
                case "Saturday":
                case "Sunday":
                    isWorking = false; break;
                default:
                    isValidDay = false;
                    Console.WriteLine("error"); break;

            }

            if (isValidDay == true)
            {
                if (isWorking == true)
                {
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.50;break;
                        case "apple":
                            price = 1.20; break;
                        case "orange":
                            price = 0.85; break;
                        case "grapefruit":
                            price = 1.45; break;
                        case "kiwi":
                            price = 2.70; break;
                        case "pineapple":
                            price = 5.50; break;
                        case "grapes":
                            price = 3.85; break;
                        default:
                            isValidFruit = false;
                            Console.WriteLine("error");break;
                    }
                }
                else
                {
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70; break;
                        case "apple":
                            price = 1.25; break;
                        case "orange":
                            price = 0.90; break;
                        case "grapefruit":
                            price = 1.60; break;
                        case "kiwi":
                            price = 3.00; break;
                        case "pineapple":
                            price = 5.60; break;
                        case "grapes":
                            price = 4.20; break;
                       
                    }
                }
            }
            if((isValidDay == true) && (isValidFruit == true))
            {
                double total = price * quntity;
                Console.WriteLine($"{total,0:F2}");
                
            }
            
        }
    }
}
