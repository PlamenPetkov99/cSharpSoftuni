using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            if (number != 0)
            {
                if ((number > 200) || (number < 100)){
                    Console.WriteLine("invalid");
                }
            }
           
        }
    }
}
