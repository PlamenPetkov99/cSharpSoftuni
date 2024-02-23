namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";//list with words separator : " " (using dictionary for count words)
            string textPath = @"..\..\..\Files\text.txt"; // text
            string outputPath = @"..\..\..\Files\output.txt"; // output file path

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                string[] words = readerWords.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < words.Length; i++)
                {
                    wordsCount[words[i].ToLower()] = 0;
                }
            }

            
            using(StreamReader reader = new StreamReader(textFilePath))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToLower();
                    string[] lineWords = line.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                    List<string> words = new List<string>();

                    foreach(string word in lineWords) // NOT SURE ABOUT THIS
                    {
                        string wordWIthoutSpecialSymbols = string.Empty;
                        for (int i = 0; i < word.Length; i++)
                        {
                            char currentChar = word[i];
                            if (!char.IsLetterOrDigit(currentChar))
                            {
                                continue;
                            }
                            wordWIthoutSpecialSymbols += currentChar; 
                        }
                        words.Add(wordWIthoutSpecialSymbols);
                    }

                    foreach (string word in words)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }
                    

                }


            }
            wordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using(StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var kvp in wordsCount)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }


        }
    }
}
