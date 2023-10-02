using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double cost = 0;
            string place = "";

            if (money <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        cost = money * 0.3; break;
                    case "winter":
                        cost = money * 0.7; break;
                }
            }
            else if (money <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        cost = money * 0.4; break;
                    case "winter":
                        cost = money * 0.8; break;
                }
            }
            else if (money > 1000)
            {
                destination = "Europe";
                cost = money * 0.9;
            }

            if (destination == "Europe")
            {
                place = "Hotel";
            }
            else if (season == "summer")
            {
                place = "Camp";
            }
            else if (season == "winter")
            {
                place = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {cost,0:F2}");

        }
    }
}