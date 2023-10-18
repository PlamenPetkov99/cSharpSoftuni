using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orders
{
    class Program
    {

        private static void order(string product , int count)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double sum = price * count;
            Console.WriteLine($"{sum,0:F2}");

        }
        static void Main(string[] args)
        {
            /*
             •	coffee – 1.50
             •	water – 1.00
             •	coke – 1.40
             •	snacks – 2.00
             */
            string product = Console.ReadLine(); //"coffee",  "water", "coke", "snacks"
            int quantity = int.Parse(Console.ReadLine());
            order(product, quantity);


        }
    }
}
