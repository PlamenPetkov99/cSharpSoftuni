using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            
            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}
