using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int iterations = int.Parse(Console.ReadLine());
            bool isNominated = false;

            for(int i = 0; i < iterations; i++)
            {
                string juryName = Console.ReadLine();
                double juryPouints = double.Parse(Console.ReadLine());

                double pointsToGive = (juryName.Length * juryPouints) / 2;
                startingPoints = startingPoints + pointsToGive;

                if (startingPoints >= 1250.5)
                {
                    isNominated = true;
                    break;
                }
            }
            double diff = Math.Abs(startingPoints - 1250.5);
            if(isNominated == true)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {startingPoints,0:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {diff,0:F1} more!");
            }
        }
    }
}
