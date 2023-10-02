using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int iteration = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < iteration; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if(currentNumber < 200)
                {
                    p1 = p1 + 1;
                }
                else if ((200 <= currentNumber) && (currentNumber <= 399))
                {
                    p2 = p2 + 1;
                }
                else if ((400 <= currentNumber) && (currentNumber <= 599))
                {
                    p3 = p3 + 1;
                }
                else if ((600 <= currentNumber) && (currentNumber <= 799))
                {
                    p4 = p4 + 1;
                }
                else if (currentNumber >= 800)
                {
                    p5 = p5 + 1;
                }

                
                

            }

            double p1Percent = p1 / iteration * 100;
            double p2Percent = p2 / iteration * 100;
            double p3Percent = p3 / iteration * 100;
            double p4Percent = p4 / iteration * 100;
            double p5Percent = p5 / iteration * 100;

            Console.WriteLine($"{p1Percent,0:F2}%");
            Console.WriteLine($"{p2Percent,0:F2}%");
            Console.WriteLine($"{p3Percent,0:F2}%");
            Console.WriteLine($"{p4Percent,0:F2}%");
            Console.WriteLine($"{p5Percent,0:F2}%");
            



        }
    }
}
