using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountDogFood = int.Parse(Console.ReadLine());
            int CountCatFood = int.Parse(Console.ReadLine());
            double sum = CountCatFood * 4 + CountDogFood * 2.50;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
