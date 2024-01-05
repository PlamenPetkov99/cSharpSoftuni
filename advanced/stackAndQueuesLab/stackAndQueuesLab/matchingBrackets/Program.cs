namespace matchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersWithBrackets = Console.ReadLine();
            Stack<int> openingBracketsIndex = new Stack<int>();

            for (int i = 0; i < numbersWithBrackets.Length; i++)
            {
                string currentSymbol = numbersWithBrackets[i].ToString();
                if(currentSymbol == "(")
                {
                    openingBracketsIndex.Push(i);
                }
                else if(currentSymbol == ")")
                {
                    int indexHisOpenBracket = openingBracketsIndex.Pop();
                    int endIndex = i;
                    int length = endIndex - indexHisOpenBracket + 1;
                    string subString = numbersWithBrackets.Substring(indexHisOpenBracket, length);
                    Console.WriteLine(subString);
                }
            }

        }
    }
}
