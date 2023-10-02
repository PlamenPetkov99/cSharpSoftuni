using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            string command = Console.ReadLine();

            while(command != "Stop")
            {
                int number = int.Parse(command);
                if(maxNum < number)
                {
                    maxNum = number;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(maxNum);



        }
    }
}
