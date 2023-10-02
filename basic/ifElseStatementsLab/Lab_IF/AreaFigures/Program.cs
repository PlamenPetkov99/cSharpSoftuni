using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                double area = a * a;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine(area);
            }
            else if (figure == "circle")
            {
                double area = Math.PI * a * a;
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine(area);
            }

        }
    }
}
