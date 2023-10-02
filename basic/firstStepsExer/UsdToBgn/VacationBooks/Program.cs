using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());

            int totalTime = countPages / pagesPerHour;
            totalTime = totalTime / countDays;

            Console.WriteLine(totalTime);
        }
    }
}
