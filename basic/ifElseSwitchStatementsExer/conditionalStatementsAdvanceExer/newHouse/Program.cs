using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int countFlower = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double price = 0;

            switch (type)
            {
                case "Roses":
                    price = 5;break;
                case "Dahlias":
                    price = 3.80;break;
                case "Tulips":
                    price = 2.80;break;
                case "Narcissus":
                    price = 3;break;
                case "Gladiolus":
                    price = 2.50;break;
            }

            double totalPrice = countFlower * price;

            switch (type)
            {
                case "Roses":
                    if (countFlower > 80)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10);
                    }
                    break;
                case "Dahlias":
                     if (countFlower > 90)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    break;
                case "Tulips":
                    if (countFlower > 80)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    break;
                case "Narcissus":
                    if (countFlower < 120)
                    {
                        totalPrice = totalPrice + (totalPrice * 0.15);
                    }
                    break;
                case "Gladiolus":
                    if (countFlower < 80)
                    {
                        totalPrice = totalPrice + (totalPrice * 0.20);
                    }
                    break;
            }

            double leftMoney = Math.Abs(money - totalPrice);
            if (money >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlower} {type} and {leftMoney,0:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {leftMoney,0:F2} leva more.");
            }
        }
    }
}
