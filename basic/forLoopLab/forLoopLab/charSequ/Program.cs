using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charSequ
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                Console.WriteLine(letter);
            }



        }
    }
}
