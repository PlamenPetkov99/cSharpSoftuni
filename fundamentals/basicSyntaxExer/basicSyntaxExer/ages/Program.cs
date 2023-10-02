using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if ((0 <= age)&&(age <= 2))
            {
                Console.WriteLine("baby");
            }
            else if ((3 <= age) && (age <= 13))
            {
                Console.WriteLine("child");
            }
            else if ((14 <= age) && (age <= 19))
            {
                Console.WriteLine("teenager");
            }
            else if ((20 <= age) && (age <= 65))
            {
                Console.WriteLine("adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("elder");
            }


        }
    }
}
