using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int sumSteps = 0;
            string command = Console.ReadLine();

            while (sumSteps < goal)
            {
                
                if (command == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    sumSteps = sumSteps + lastSteps;
                    break;

                }
                int steps = int.Parse(command);
                sumSteps = sumSteps + steps;

                command = Console.ReadLine();
            }
            int diff = Math.Abs(goal - sumSteps);
            if (sumSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{diff} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{diff} more steps to reach goal.");
            }
            
        }
    }
}
