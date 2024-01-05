using System.Security.Cryptography.X509Certificates;

namespace printEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queInt = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queInt.Enqueue(numbers[i]);
                }

            }

            Console.WriteLine(string.Join(", ",queInt));


        }
    }
}
