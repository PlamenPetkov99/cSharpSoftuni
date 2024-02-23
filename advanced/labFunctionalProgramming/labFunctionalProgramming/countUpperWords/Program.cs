namespace countUpperWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> getfirstChar = word => char.IsUpper(word[0]);
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(word => getfirstChar(word)).ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


        }
    }
}
