using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double countWins = 0;
            int pointsFromGames = 0;

            for (int i = 0; i < iterations; i++)
            {
                string result = Console.ReadLine();

                switch (result)
                {
                    case "W":
                        countWins = countWins + 1;
                        pointsFromGames = pointsFromGames + 2000;
                        break;
                    case "F":
                        pointsFromGames = pointsFromGames + 1200;
                        break;
                    case "SF":
                        pointsFromGames = pointsFromGames + 720;
                        break;
                }


            }
            int totalPoints = pointsFromGames + startingPoints;
            int averagePercentWins = pointsFromGames / iterations;
            double percentWins = (countWins / iterations) * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePercentWins}");
            Console.WriteLine($"{percentWins,0:F2}%");
        }
    }
}
