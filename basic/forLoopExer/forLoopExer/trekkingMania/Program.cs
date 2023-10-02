using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double K2 = 0;
            double everest = 0;

            for(int i = 0; i < iterations; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                totalPeople = totalPeople + countPeople;

                if (countPeople <= 5)
                {
                    musala = musala + countPeople;
                }
                else if ((6 <= countPeople) && (countPeople <= 12))
                {
                    monblan = monblan + countPeople;
                }
                else if ((13 <= countPeople) && (countPeople <= 25))
                {
                    kilimandjaro = kilimandjaro + countPeople;
                }
                else if ((26 <= countPeople) && (countPeople <= 40))
                {
                    K2 = K2 + countPeople;
                }
                else if (41 <= countPeople)
                {
                    everest = everest + countPeople;
                }
            }

            double musalaPercent = musala / totalPeople * 100;
            double monblanPercent = monblan / totalPeople * 100;
            double kilimandjaroPercent = kilimandjaro / totalPeople * 100;
            double K2Percent = K2 / totalPeople * 100;
            double everestPercent = everest / totalPeople * 100;

            Console.WriteLine($"{musalaPercent,0:F2}%");
            Console.WriteLine($"{monblanPercent,0:F2}%");
            Console.WriteLine($"{kilimandjaroPercent,0:F2}%");
            Console.WriteLine($"{K2Percent,0:F2}%");
            Console.WriteLine($"{everestPercent,0:F2}%");

        }
    }
}
