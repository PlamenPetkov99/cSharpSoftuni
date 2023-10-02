using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            string age = Console.ReadLine();
            string city = Console.ReadLine();
            Console.WriteLine($"You are {name} {family}, a {age}-years old person from {city}.");
        }
    }
}
