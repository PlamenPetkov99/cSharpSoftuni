namespace countCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> charOcurrance = new Dictionary<char, int>();

            foreach (string word in words)
            {
                string currentWord = word;
                for (int i = 0; i < currentWord.Length; i++)
                {
                    char currentCharacter = currentWord[i];
                    if (!charOcurrance.ContainsKey(currentCharacter))
                    {
                        charOcurrance[currentCharacter] = 1;
                    }
                    else
                    {
                        charOcurrance[currentCharacter]++;
                    }

                }

            }

            foreach (KeyValuePair<char,int> kvp in charOcurrance)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}