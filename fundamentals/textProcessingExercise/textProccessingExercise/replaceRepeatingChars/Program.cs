using System.Text;
using System;




namespace replaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            StringBuilder result = new StringBuilder();
            char lastChar = default;

            foreach(char currentCharacter in word)
            {
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
