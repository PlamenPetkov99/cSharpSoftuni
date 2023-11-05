namespace randomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<string> words = Console.ReadLine().Split().ToList();

            for (int i = 0; i < words.Count; i++)
            {
                int randomIndex = random.Next(words.Count);
                string currentWord = words[i];

                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;

            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}