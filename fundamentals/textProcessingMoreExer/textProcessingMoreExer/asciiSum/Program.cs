using System.Text;

namespace asciiSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startCharacter = char.Parse(Console.ReadLine());
            char endCharacter = char.Parse(Console.ReadLine());
            string allChars = Console.ReadLine();
            string allcharactersBetweenStartEnd = string.Empty;

            for (int i = (int)startCharacter +1 ; i < (int)endCharacter; i++)
            {
                allcharactersBetweenStartEnd+=(char)i;
            }

            string commonChars = string.Empty;
            foreach (char character in allcharactersBetweenStartEnd)
            {
                foreach (char characterInFilter in allChars)
                {
                    if(characterInFilter == character)
                    {
                        commonChars += character;
                    }
                }
            }

            int sum = 0;
            foreach (char comChar in commonChars)
            {
                sum += (int)comChar;
            }
            Console.WriteLine(sum);
        }
    }
}
