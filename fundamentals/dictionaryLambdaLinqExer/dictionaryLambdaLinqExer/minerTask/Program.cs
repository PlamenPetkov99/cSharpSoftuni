namespace minerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = default;
            Dictionary<string, long> mine = new Dictionary<string, long>();

            while((resource = Console.ReadLine()) != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!mine.ContainsKey(resource))
                {
                    mine[resource] = quantity;
                }
                else
                {
                    mine[resource] += quantity;
                }

            }

            foreach (KeyValuePair<string,long> kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}