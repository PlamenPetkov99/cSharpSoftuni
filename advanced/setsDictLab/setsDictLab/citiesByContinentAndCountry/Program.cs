namespace citiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];

                if (!map.ContainsKey(continent))
                {
                    map[continent] = new Dictionary<string, List<string>>();
                    map[continent][country] = new List<string>();
                    map[continent][country].Add(city);
                }
                else//if there is a key
                {
                    if (!map[continent].ContainsKey(country))
                    {
                        map[continent][country] = new List<string>();
                        map[continent][country].Add(city);

                    }
                    else
                    {
                        map[continent][country].Add(city);
                    }

                }

            }

            foreach (var kvp in map)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var countryCities in kvp.Value)
                {
                    Console.Write($"{countryCities.Key} -> ");
                    Console.WriteLine(string.Join(", ",countryCities.Value));
                }
            }



        }
    }
}
