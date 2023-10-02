using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // valid coins : 0.1, 0.2, 0.5, 1 and 2

            string command = Console.ReadLine();
            double budget = 0;
            double price = 0;
            double lastPrice = 0;
            bool isvalidProduct = true;

            while (command != "Start")
            {
                double insertedCoins = double.Parse(command);

                switch (insertedCoins)
                {
                    case 0.1:
                        budget = budget + 0.1;
                        break;
                    case 0.2:
                        budget = budget + 0.2;
                        break;
                    case 0.5:
                        budget = budget + 0.5;
                        break;
                    case 1:
                        budget = budget + 1;
                        break;
                    case 2:
                        budget = budget + 2;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {insertedCoins}");
                        break;
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        isvalidProduct = false;
                        break;
                }

                if ((budget >= price) && (isvalidProduct == true))
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    budget = budget - price;
                    lastPrice = price;
                }
                else if(budget < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
                isvalidProduct = true;
            }

            
            Console.WriteLine($"Change: {budget,0:F2}");


        }
    }
}
