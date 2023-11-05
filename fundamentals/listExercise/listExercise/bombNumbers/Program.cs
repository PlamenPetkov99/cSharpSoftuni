using System.Diagnostics.Metrics;

namespace bombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> bombAndPower = Console.ReadLine().Split().ToList();
            int bombNumber = int.Parse(bombAndPower[0]);
            int bombPower = int.Parse(bombAndPower[1]);

            while(numbers.Contains(bombNumber))
            {
                int bombIndex = numbers.IndexOf(bombNumber);
                int leftIndex = Math.Max(0, bombIndex - bombPower);
                int rightIndex = Math.Min(numbers.Count - 1, bombIndex + bombPower);


                int range = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, range);
                
            }

            Console.WriteLine(numbers.Sum());


            // 1 2 3 4 5 6
            // 0 1 2 3 4 5 
            //   i i b i i


        }
    }
}