using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());
            bool isSliceZero = false;
            int lastTaken = 0;
            int beforeTaken = 0;

            int slices = cakeHeight * cakeLenght;

            string command = Console.ReadLine();

            while(command != "STOP")
            {
                int takenSlices = int.Parse(command);
                lastTaken = takenSlices;
                beforeTaken = slices;
                slices = slices - takenSlices;
                if(slices < 0)
                {
                    isSliceZero = true;
                    break;
                }
                command = Console.ReadLine();
            }
            int diff = Math.Abs(beforeTaken - lastTaken);
            if (isSliceZero)
            {
                Console.WriteLine($"No more cake left! You need {diff} pieces more.");
            }
            else
            {
                Console.WriteLine($"{diff} pieces are left.");
            }
           
        }
    }
}
