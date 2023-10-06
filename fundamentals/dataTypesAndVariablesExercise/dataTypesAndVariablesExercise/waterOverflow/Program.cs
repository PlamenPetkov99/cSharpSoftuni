using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersInTank = 0;
            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if(capacity - quantities >= 0)
                {
                    capacity = capacity - quantities;
                    litersInTank = litersInTank + quantities;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(litersInTank);



        }
    }
}
