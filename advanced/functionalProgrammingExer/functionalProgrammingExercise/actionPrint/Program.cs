using System.Threading.Channels;

namespace actionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> printNames = name => Console.WriteLine(name);
            Array.ForEach(names,printNames);

        }

    }
}
