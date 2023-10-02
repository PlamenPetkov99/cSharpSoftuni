using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double usd = double.Parse(input);
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
