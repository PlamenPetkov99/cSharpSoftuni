using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsCount
{
    class Program
    {

        private static int Getvowels(string word)
        {
            int count = 0;
            foreach (char w in word)
            {
                switch (w)
                {
                    case 'a':
                        count = count + 1;
                        break;
                    case 'e':
                        count = count + 1;
                        break;
                    case 'i':
                        count = count + 1;
                        break;
                    case 'o':
                        count = count + 1;
                        break;
                    case 'u':
                        count = count + 1;
                        break;
                    case 'y':
                        count = count + 1;
                        break;
                }

            }


            return count;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            int numberVowels = Getvowels(word);
            Console.WriteLine(numberVowels);


        }
    }
}
