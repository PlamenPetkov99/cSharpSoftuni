namespace ListPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = num =>
            {
                foreach (int divider in dividers)
                {
                    if(num % divider != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            numbers = numbers.Where(num => predicate(num)).ToList();
            Console.WriteLine(string.Join(" ",numbers));


        }

        

    }
}
