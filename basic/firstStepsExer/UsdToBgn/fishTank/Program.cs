using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            
            double busySpace = percent / 100;

            int area = lenght * width * height;
            double areainLiters = area * 0.001;
            double neededLiters = areainLiters * (1 - busySpace);

            Console.WriteLine(neededLiters);
        }
    }
}
