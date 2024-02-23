using System.Reflection.Metadata.Ecma335;

namespace findEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] boundry = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = boundry[0];
            int end = boundry[1];

            Func<int, int, List<int>> createList = (start, end) =>
            {
                List<int> tempList = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    tempList.Add(i);
                }

                return tempList;
            };

            List<int> numbers = createList(start, end);
            int[] numbersArr = numbers.ToArray();
            
            string condition = Console.ReadLine();

            Func<int, bool> predicate = CreatePredicate(condition);
            numbersArr = numbersArr.Where(predicate).ToArray();

            Action<int> printNumbers = num => Console.Write(num + " "); 
            Array.ForEach(numbersArr, printNumbers);


        }

        private static Func<int, bool> CreatePredicate(string condition)
        {
            if (condition == "odd")
            {
                return s => s % 2 != 0;
            }

            return s => s % 2 == 0;
        }
    }
}
