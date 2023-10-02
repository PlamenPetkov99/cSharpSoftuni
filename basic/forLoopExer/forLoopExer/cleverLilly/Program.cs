using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toyCount = 0;
            double raisedMoney = 0;
            int gavedMoney = 10;

            for (int i = 1; i <= iteration; i++)
            {
                if (i % 2 == 0)
                {
                    raisedMoney = raisedMoney + gavedMoney;
                    gavedMoney = gavedMoney + 10;
                    raisedMoney = raisedMoney - 1;
                }
                else
                {
                    toyCount = toyCount + 1;
                }

            }
            double moneyFromToys = toyCount * toyPrice;
            double totalMoney = raisedMoney + moneyFromToys;
            double diff = Math.Abs(totalMoney - washerPrice);
            if (totalMoney >= washerPrice)
            {
                Console.WriteLine($"Yes! {diff,0:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diff,0:F2}");
            }


            

        }
    }
}
