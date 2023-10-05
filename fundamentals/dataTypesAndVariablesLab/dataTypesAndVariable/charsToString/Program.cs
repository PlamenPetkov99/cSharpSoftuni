using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";

            for (int i = 0; i < 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }
            Console.WriteLine(word);

        }
    }
}
