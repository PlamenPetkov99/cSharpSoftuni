using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split().ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];

                }
                else
                {
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];

                }




            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));



        }
    }
}
