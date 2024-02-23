namespace predicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> filterName = name => name.Length <= n;

            names = names.Where(name => filterName(name)).ToArray();
            Action<string> printName = name => Console.WriteLine(name);

            Array.ForEach(names, printName);
            

        }
    }
}
