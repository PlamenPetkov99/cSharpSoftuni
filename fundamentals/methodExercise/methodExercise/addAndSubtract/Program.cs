using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addAndSubtract
{
    class Program
    {

        private static int Getsum(int n1 , int n2)
        {
            int result = 0;
            result = n1 + n2;
            return result;
        }

        private static int Getsub(int n1, int n2)
        {
            int result = 0;
            result = n1 - n2;

            return result;
        }
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int result = 0;

            result = Getsub(Getsum(n1, n2),n3);

            Console.WriteLine(result);
        }
    }
}
