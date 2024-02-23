namespace knightOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> printNames = name => Console.WriteLine($"Sir {name}");
            foreach (string name in names)
            {
                printNames(name);

            }

        }
    }
}
