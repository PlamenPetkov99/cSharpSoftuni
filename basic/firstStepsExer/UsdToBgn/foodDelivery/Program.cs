using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVeganMenu = int.Parse(Console.ReadLine());

            double total = countChickenMenu * 10.35 + countFishMenu * 12.40 + countVeganMenu * 8.15;
            double dessertPrice = total * 0.20;
            total = total + dessertPrice + 2.50;
            Console.WriteLine(total);
        }
    }
}
