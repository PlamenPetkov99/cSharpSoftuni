namespace morseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            List<string> codeByWords = code.Split(" | ").ToList();
            List<string> wordsEnglish = new List<string>();
            foreach (string currentWord in codeByWords)
            {
                string currentWordEnglish = string.Empty;
                List<string> characterByCharacter = currentWord.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (string currentChar in characterByCharacter)
                {
                    char currentCharEng = default;
                    switch (currentChar) //. // -
                    {
                        case ".-":
                            currentCharEng = 'A';
                            break;
                        case "-...":
                            currentCharEng = 'B';
                            break;
                        case "-.-.":
                            currentCharEng = 'C';
                            break;
                        case "-..":
                            currentCharEng = 'D';
                            break;
                        case ".":
                            currentCharEng = 'E';
                            break;
                        case "..-.":
                            currentCharEng = 'F';
                            break;
                        case "--.":
                            currentCharEng = 'G';
                            break;
                        case "....":
                            currentCharEng = 'H';
                            break;
                        case "..":
                            currentCharEng = 'I';
                            break;
                        case ".---":
                            currentCharEng = 'J';
                            break;
                        case "-.-":
                            currentCharEng = 'K';
                            break;
                        case ".-..":
                            currentCharEng = 'L';
                            break;
                        case "--":
                            currentCharEng = 'M';
                            break;
                        case "-.":
                            currentCharEng = 'N';
                            break;
                        case "---":
                            currentCharEng = 'O';
                            break;
                        case ".--.":
                            currentCharEng = 'P';
                            break;
                        case "--.-":
                            currentCharEng = 'Q';
                            break;
                        case ".-.":
                            currentCharEng = 'R';
                            break;
                        case "...":
                            currentCharEng = 'S';
                            break;
                        case "-":
                            currentCharEng = 'T';
                            break;
                        case "..-":
                            currentCharEng = 'U';
                            break;
                        case "...-":
                            currentCharEng = 'V';
                            break;
                        case ".--":
                            currentCharEng = 'W';
                            break;
                        case "-..-":
                            currentCharEng = 'X';
                            break;
                        case "-.--":
                            currentCharEng = 'Y';
                            break;
                        case "--..":
                            currentCharEng = 'Z';
                            break;
                    }

                    currentWordEnglish += currentCharEng;

                }

                wordsEnglish.Add(currentWordEnglish);

            }
            Console.WriteLine(string.Join(" ",wordsEnglish));
        }
    }
}
