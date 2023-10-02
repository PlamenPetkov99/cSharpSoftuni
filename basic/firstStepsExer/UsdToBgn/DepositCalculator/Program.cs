using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedMoney = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());
            yearPercent = yearPercent / 100;
            double sum = depositedMoney + time * ((depositedMoney * yearPercent) / 12);
            Console.WriteLine(sum);
        }
    }
}
