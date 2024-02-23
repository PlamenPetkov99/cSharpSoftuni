namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string result = string.Empty;
            int lineNumber = 1;
            foreach (string line in lines)
            {
                char[] charAr = line.ToCharArray();
                int countLetters = 0;
                int countPunct = 0;
                foreach (char character in charAr)
                {
                    if (char.IsLetter(character))
                    {
                        countLetters++;
                    }
                    else if( char.IsPunctuation(character))
                    {
                        countPunct++;
                    }
                }
                result += $"Line {lineNumber++}: {line} ({countLetters})({countPunct})\n";
                
            }



            File.WriteAllText(outputFilePath, result);
        }
    }
}
