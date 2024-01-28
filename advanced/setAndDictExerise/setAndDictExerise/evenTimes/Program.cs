namespace evenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberCounter = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numberCounter.ContainsKey(number))
                {
                    numberCounter[number] = 1;
                }
                else
                {
                    numberCounter[number]++;
                }

            }

            Dictionary<int, int> result = numberCounter.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
