namespace periodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentChemicals = Console.ReadLine().Split();
                foreach (var chemical in currentChemicals)
                {
                    chemicals.Add(chemical);
                }

            }

            Console.WriteLine(string.Join(" ",chemicals));
        }
    }
}
