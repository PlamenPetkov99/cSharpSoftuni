namespace wordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string,int> dict = new Dictionary<string,int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                dict[currentWord] = currentWord.Length;
            }

            dict = dict.Where(kvp => kvp.Value % 2 == 0).ToDictionary(kvp => kvp.Key , kvp => kvp.Value);

            foreach (KeyValuePair<string,int> kvp in dict)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}