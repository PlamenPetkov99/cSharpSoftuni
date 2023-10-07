using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long bestsnowballValue = long.MinValue;
            int bestsnowballSnow = 0;
            int bestsnowballTime = 0;
            int bestssnowballQuality = 0;
            
            for (int i = 0; i < n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                long currentValue = (snowBallSnow / snowBallTime);
                currentValue = currentValue + (long)Math.Pow(currentValue, snowBallQuality);

                if (currentValue >= bestsnowballValue)
                {
                    bestsnowballSnow = snowBallSnow;
                    bestsnowballValue = currentValue;
                    bestsnowballTime = snowBallTime;
                    bestssnowballQuality = snowBallQuality;

                }

            }


            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestsnowballValue} ({bestssnowballQuality})");


        }
    }
}
