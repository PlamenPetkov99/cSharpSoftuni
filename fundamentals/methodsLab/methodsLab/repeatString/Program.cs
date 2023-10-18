using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatString
{
    class Program
    {

        static void counter(string w , int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(w);
            }
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            counter(word, n);

        }
    }
}
