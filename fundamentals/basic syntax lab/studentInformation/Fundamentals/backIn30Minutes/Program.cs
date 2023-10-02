using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMin = (hours * 60) + minutes;

            totalMin = totalMin + 30;

            int hoursAfter = totalMin / 60;
            int minutesAfter = totalMin % 60;

            if(minutesAfter > 59)
            {
                minutesAfter = 0;
                hoursAfter = hoursAfter + 1;
            }
            else if(hoursAfter > 23)
            {
                hoursAfter = 0;

            }

            if(minutesAfter < 10)
            {
                Console.WriteLine($"{hoursAfter}:0{minutesAfter}");
            }
            else
            {
                Console.WriteLine($"{hoursAfter}:{minutesAfter}");
            }


        }
    }
}
