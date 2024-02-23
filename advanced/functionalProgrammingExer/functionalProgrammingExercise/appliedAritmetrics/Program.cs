using System.Threading.Channels;

namespace appliedAritmetrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            Action<int> printArray = num => Console.Write(num + " ");
            while ((command = Console.ReadLine()) != "end")
            {
                if(command == "print")
                {
                    Array.ForEach(numbers, printArray);
                    Console.WriteLine();
                    continue;
                }
                Func<int, int> function = CreateFunction(command);
                numbers = numbers.Select(function).ToArray();

            }

        }

        private static Func<int, int> CreateFunction(string command)
        {
            if (command == "add")
            {
                return num => num + 1;
            }
            else if (command == "multiply")
            {
                return num => num * 2;
            }

            return num => num - 1;


        }
    }
}
