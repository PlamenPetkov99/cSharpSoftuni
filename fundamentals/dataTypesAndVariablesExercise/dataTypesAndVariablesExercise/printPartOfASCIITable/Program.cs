using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = start; i <= end; i++)
            {
                result += (char)i + " ";
            }

            Console.WriteLine(result);
        }
    }
}
