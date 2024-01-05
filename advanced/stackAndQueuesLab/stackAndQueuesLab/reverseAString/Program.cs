namespace reverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Stack<char> reverseString = new Stack<char>();

            foreach (char symbol in sentence)
            {
                reverseString.Push(symbol);
            }

            for (int i = 0; i < reverseString.Count;)
            {
                Console.Write(reverseString.Pop());
            }
            
        }
    }
}
