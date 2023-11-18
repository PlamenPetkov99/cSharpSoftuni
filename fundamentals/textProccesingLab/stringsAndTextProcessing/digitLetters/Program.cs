using System.Text;

namespace digitLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder stringDigits = new StringBuilder();
            StringBuilder stringChars = new StringBuilder();
            StringBuilder stringLetters = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];

                if(char.IsDigit(currentCharacter))
                {
                    stringDigits.Append(currentCharacter);
                }
                else if(char.IsLetter(currentCharacter)) 
                {
                    stringLetters.Append(currentCharacter);
                }
                else
                {
                    stringChars.Append(currentCharacter);
                }
            }

            Console.WriteLine(stringDigits);
            Console.WriteLine(stringLetters);
            Console.WriteLine(stringChars);


        }
    }
}
