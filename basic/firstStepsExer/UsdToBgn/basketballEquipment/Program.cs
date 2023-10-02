using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double priceShoes = yearTax - (yearTax * 0.40);
            double priceClothes = priceShoes - (priceShoes * 0.20);
            double priceBall = priceClothes / 4;
            double priceAcc = priceBall / 5;
            double total = yearTax + priceShoes + priceClothes + priceBall + priceAcc;
            Console.WriteLine(total);
        }
    }
}
