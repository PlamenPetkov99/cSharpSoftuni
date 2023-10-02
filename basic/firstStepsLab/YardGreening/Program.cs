using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double fullPrice = yards * 7.61;
            double discount = fullPrice * 0.18;
            double sum = fullPrice - discount;
            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
