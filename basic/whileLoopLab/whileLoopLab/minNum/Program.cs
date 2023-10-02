using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (minNum > number)
                {
                    minNum = number;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
