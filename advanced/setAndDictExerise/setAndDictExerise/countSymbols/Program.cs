using System.Collections.Specialized;

namespace countSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> characters = new Dictionary<char, int>();

            string word = Console.ReadLine();

            foreach(char character in word)
            {
                if (!characters.ContainsKey(character))
                {
                    characters[character] = 1;
                }
                else
                {
                    characters[character]++;
                }
            }

            characters = characters.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var kvp in characters)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }

        }

    }
}
