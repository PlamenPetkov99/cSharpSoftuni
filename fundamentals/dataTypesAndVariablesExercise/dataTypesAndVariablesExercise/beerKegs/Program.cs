using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nameOfTheBigestKeg = "";
            double maxVolume = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolume = 0;
                //formula for biggest keg : Math.PI * (radius*radius) * height

                currentVolume = Math.PI * (radius * radius) * height;

                if(currentVolume >= maxVolume)
                {
                    maxVolume = currentVolume;
                    nameOfTheBigestKeg = name;
                }


            }

            Console.WriteLine(nameOfTheBigestKeg);



        }
    }
}
