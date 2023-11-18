namespace textFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            string sentence = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string wordForReplace = default;
                for (int i = 0; i < word.Length; i++)
                {
                    wordForReplace += "*";
                }
                while (sentence.Contains(word))
                {

                    sentence = sentence.Replace(word, wordForReplace);
                }

            }

            Console.WriteLine(sentence);
        }
    }
}
