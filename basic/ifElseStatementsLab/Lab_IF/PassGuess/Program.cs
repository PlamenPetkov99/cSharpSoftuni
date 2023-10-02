using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if (guess == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
