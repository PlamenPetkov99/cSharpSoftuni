using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                switch (currentLetter)
                {
                    case 'a':
                        sum = sum + 1;
                        break;
                    case 'e':
                        sum = sum + 2;
                        break;
                    case 'i':
                        sum = sum + 3;
                        break;
                    case 'o':
                        sum = sum + 4;
                        break;
                    case 'u':
                        sum = sum + 5;
                        break;


                }

            




            }
            Console.WriteLine(sum);



        }
    }
}
