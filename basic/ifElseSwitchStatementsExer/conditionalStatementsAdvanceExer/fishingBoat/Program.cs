using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;break;
                case "Summer":
                case "Autumn":
                    price = 4200;break;
                case "Winter":
                    price = 2600;break;
            }

            if (countFishers <= 6)
            {
                price = price - (price * 0.10);
            }
            else if ((7 <= countFishers) && (countFishers <= 11))
            {
                price = price - (price * 0.15);
            }
            else if (countFishers >= 12)
            {
                price = price - (price * 0.25);
            }

            if (season != "Autumn")
            {
                if (countFishers % 2 == 0)
                {
                    price = price - (price * 0.05);
                }
            }

            double leftMoney = Math.Abs(price - money);
            
            if (money >= price)
            {
                Console.WriteLine($"Yes! You have {leftMoney,0:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {leftMoney,0:F2} leva.");
            }
        }
    }
}
