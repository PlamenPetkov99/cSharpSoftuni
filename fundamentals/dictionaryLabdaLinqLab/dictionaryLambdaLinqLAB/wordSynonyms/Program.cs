namespace wordSynonyms
{
    /*
     3
    cute
    adorable
    cute
    charming
    smart
    clever
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //The key of the dictionary will be the word
            //The value will be a list of all the synonyms of that word

            int countWords = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<string>> wordsWithSynonyms = new Dictionary<string, List<string>>();


            for (int i = 0; i < countWords; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();

                if (!wordsWithSynonyms.ContainsKey(currentWord))
                {
                    wordsWithSynonyms[currentWord] = new List<string>();
                    wordsWithSynonyms[currentWord].Add(currentSynonym);
                }
                else
                {
                    wordsWithSynonyms[currentWord].Add(currentSynonym);
                }
                
            }

            // Print "{word} - {synonym1, synonym2, …, synonymN}"

            foreach (KeyValuePair<string,List<string>> kvp in wordsWithSynonyms)
            {

                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}