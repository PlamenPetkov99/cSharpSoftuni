using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middleCharacters
{
    class Program
    {

        private static void Getmid(string word)
        {
            if(word.Length % 2 == 0)
            {
                int middleI = word.Length / 2;
                Console.Write($"{word[middleI-1]}{word[middleI]}");
            }
            else
            {
                int middleI = (word.Length / 2);
                Console.Write($"{word[middleI]}");
            }

            

        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Getmid(word);

        }
    }
}
