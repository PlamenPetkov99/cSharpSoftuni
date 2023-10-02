using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMaterials
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPenPacket = int.Parse(Console.ReadLine());
            int countMarkersPacket = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());
            discountPercent = discountPercent / 100;

            double totalSum = countPenPacket * 5.80 + countMarkersPacket * 7.20 + litersCleaner * 1.20;
            totalSum = totalSum - (totalSum * discountPercent);
            Console.WriteLine(totalSum);
             


        }
    }
}
