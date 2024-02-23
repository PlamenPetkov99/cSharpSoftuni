using System.Reflection.Metadata.Ecma335;

namespace triFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, int, bool> predicate = (name,number) =>
            {
                int sum = 0;
                foreach (char character in name)
                {
                    sum += character;
                }

                return sum >= number;

            };

            names = names.Where(name => predicate(name, n)).ToArray();

            string result = names.First();
            Console.WriteLine(result);

        }
    }
}
