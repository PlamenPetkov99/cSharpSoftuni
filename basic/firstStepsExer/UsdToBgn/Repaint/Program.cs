using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaint
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int bensin = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalNaylon = (naylon + 2) * 1.50;
            double totalPaint = (paint + (paint * 0.10)) * 14.50;
            double totalBensin = bensin * 5;
            double totalBags = 0.40;

            double total = totalNaylon + totalPaint + totalBensin + totalBags;
            double totalForWork = (total * 0.30) * hours;
            total = total + totalForWork;
            Console.WriteLine(total); 
        }
    }
}
