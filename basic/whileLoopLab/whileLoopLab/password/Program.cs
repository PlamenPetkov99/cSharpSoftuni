using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string guess = Console.ReadLine();

            while (guess != password)
            {
                guess = Console.ReadLine();

            }

            Console.WriteLine($"Welcome {username}!");


        }
    }
}
