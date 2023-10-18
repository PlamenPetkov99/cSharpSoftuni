using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactersInRange
{
    class Program
    {

        private static void Getall(char a, char b)
        {
            int start = (int)a;
            int end = (int)b;

            for (int i = start+1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if ((int)end < (int)start)
            {
                char temporary = start;
                start = end;
                end = temporary;
            }

            Getall(start, end);


        }
    }
}
