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

            int bombIndex = numbers.IndexOf(bombNumber);

            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();

            for (int i = 0; i < bombIndex; i++) // creating left side
            {
                leftSide.Add(numbers[i]);
            }
            for (int i = bombIndex + 1; i <= numbers.Count-1; i++)// creating right side
            {
                rightSide.Add(numbers[i]);
            }

            if(leftSide.Count < bombPower)
            {
                leftSide.Clear();
            }
            else
            {
                leftSide.Reverse();
                leftSide.RemoveRange(0, bombPower);
                leftSide.Reverse();
            }


            ;




        }
    }
}