using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Monday":
                    price = 12;break;
                case "Tuesday":
                    price = 12; break;
                case "Wednesday":
                    price = 14; break;
                case "Thursday":
                    price = 14; break;
                case "Friday":
                    price = 12; break;
                case "Saturday":
                    price = 16; break;
                case "Sunday":
                    price = 16; break;
            }

            Console.WriteLine(price);
        }
    }
}
