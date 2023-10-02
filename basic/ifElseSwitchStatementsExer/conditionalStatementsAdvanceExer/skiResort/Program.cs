using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skiResort
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            countDays = countDays - 1;
            double cost = 0;

            switch (type)
            {
                case "room for one person":
                    cost = 18;
                    break;
                case "apartment":
                    cost = 25;
                    if (countDays < 10)
                    {
                        cost = cost - (cost * 0.30);
                    }
                    else if ((10 < countDays) && (countDays < 15))
                    {
                        cost = cost - (cost * 0.35);
                    }
                    else if (countDays > 15)
                    {
                        cost = cost - (cost * 0.50);
                    }
                        break;
                case "president apartment":
                    cost = 35;
                    if (countDays < 10)
                    {
                        cost = cost - (cost * 0.10);
                    }
                    else if ((10 < countDays) && (countDays < 15))
                    {
                        cost = cost - (cost * 0.15);
                    }
                    else if (countDays > 15)
                    {
                        cost = cost - (cost * 0.20);
                    }
                    break;
            }

            switch (grade)
            {
                case "positive":
                    cost = cost + (cost * 0.25);
                    break;
                case "negative":
                    cost = cost - (cost * 0.10);
                    break;
            }
            double total = countDays * cost;
            Console.WriteLine($"{total,0:F2}");


        }
    }
}
