using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double currentMoney = 0;

            while (destination != "End")
            {
                double travelCost = double.Parse(Console.ReadLine());
                currentMoney = 0;
                while (currentMoney < travelCost)
                {
                    double raisedMoney = double.Parse(Console.ReadLine());
                    currentMoney = currentMoney + raisedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
                /*if (destination != "End")
                {
                    travelCost = double.Parse(Console.ReadLine());
                }*/
            }


        }
    }
}
