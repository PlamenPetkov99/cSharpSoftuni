using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int col = 1;col <= n; col++)
            {
                for(int row = 1;row <= col; row++)
                {
                    if(current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }

           


        }
    }
}
