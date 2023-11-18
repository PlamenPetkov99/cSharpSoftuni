using System.Text;

namespace substring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                word = word.Replace(wordToRemove,"");

            }

            Console.WriteLine(word);

        }
    }
}
