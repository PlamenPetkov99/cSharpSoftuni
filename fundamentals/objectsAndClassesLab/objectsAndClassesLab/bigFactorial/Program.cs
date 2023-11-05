using System.Numerics;

namespace bigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = n; i > 0; i--)
            {
                f = f * i;
            }
            Console.WriteLine(f);


        }
    }
}