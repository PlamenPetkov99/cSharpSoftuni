using System.Text;

namespace replaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            StringBuilder result = new StringBuilder();

            foreach(char currentCharacter in word)
            {
                char lastChar = default;
                if(currentCharacter == lastChar)
                {
                    continue;
                }
                else
                {
                    result.Append(currentCharacter);
                }
                
                
                lastChar = currentCharacter;
            }

            Console.WriteLine(result);
        }
    }
}
