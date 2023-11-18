namespace repeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int currentWordLenght = words[i].Length;

                for (int j = 0; j < currentWordLenght; j++)
                {
                    result += currentWord;
                }

            }

            Console.WriteLine(result);
        }
    }
}
