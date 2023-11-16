namespace oddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> sortedWordsOcurrance = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                if (sortedWordsOcurrance.ContainsKey(currentWord))
                {
                    sortedWordsOcurrance[currentWord]++;
                }
                else
                {
                    sortedWordsOcurrance[currentWord] = 1;
                }
            }

            foreach (KeyValuePair<string,int> kvp in sortedWordsOcurrance)
            {
                if(kvp.Value % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }

        }
    }
}