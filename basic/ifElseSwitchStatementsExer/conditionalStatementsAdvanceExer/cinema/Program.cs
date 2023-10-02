using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double price = 0;
            int totalSeats = row * col;
            switch (type)
            {
                case "Premiere":
                    price = 12; break;
                case "Normal":
                    price = 7.50; break;
                case "Discount":
                    price = 5; break;

            }

            double income = price * totalSeats;

            Console.WriteLine($"{income,0:F2} leva");


        }
    }
}
