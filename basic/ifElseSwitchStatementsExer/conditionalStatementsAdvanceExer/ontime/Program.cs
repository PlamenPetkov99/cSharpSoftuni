using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontime
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int totalExamMinute = (examHour * 60) + examMinute;
            int totalArriveMinute = (arriveHour * 60) + arriveMinute;

            int difference = Math.Abs(totalExamMinute - totalArriveMinute);



            if (totalExamMinute < totalArriveMinute)
            {
                Console.WriteLine("Late");
                int hourLate = difference / 60;
                int minlate = difference % 60;

                if (difference >= 60)
                {
                    if (minlate <= 10)
                    {
                        Console.WriteLine($"{hourLate}:0{minlate} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourLate}:{minlate} hours after the start");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{minlate} minutes after the start");
                }
            }
            else if ((totalExamMinute == totalArriveMinute) || (totalExamMinute - 30 <= totalArriveMinute))
            {
                if (difference == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference % 60} minutes before the start");
                }
            }
            else if (totalExamMinute > totalArriveMinute + 30)
            {
                Console.WriteLine("Early");
                int hourEarly = difference / 60;
                int minEarly = difference % 60;

                if (difference >= 60)
                {
                    if (minEarly <= 10)
                    {
                        Console.WriteLine($"{hourEarly}:0{minEarly} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourEarly}:{minEarly} hours before the start");
                    }

                }
                else
                {
                    Console.WriteLine($"{minEarly} minutes before the start");
                }
            }

        }
    }
}
