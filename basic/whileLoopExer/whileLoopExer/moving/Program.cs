using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());
            int totalFreeSpace = widthFreeSpace * lenghtFreeSpace * heightFreeSpace;
            int totalBusySpace = 0;
            bool noMoreSpace = false;

            string command = Console.ReadLine();

            while(command != "Done")
            {
                int countBoxes = int.Parse(command);
                totalBusySpace = totalBusySpace + countBoxes;
                if(totalBusySpace > totalFreeSpace)
                {
                    noMoreSpace = true;
                    break;
                }

                command = Console.ReadLine();
            }
            int diff = Math.Abs(totalBusySpace - totalFreeSpace);
            if (noMoreSpace)
            {
                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{diff} Cubic meters left.");
            }


        }
    }
}
