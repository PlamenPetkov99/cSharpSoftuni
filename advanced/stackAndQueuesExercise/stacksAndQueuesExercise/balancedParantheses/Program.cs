namespace balancedParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> parantheses = new Stack<string>();

            string allSymbols = Console.ReadLine();

            for(int i = 0; i < allSymbols.Length; i++)
            {
                string currentSymbol = allSymbols[i].ToString();
                if(currentSymbol == "(")
                {
                    parantheses.Push(currentSymbol);
                }
                else if(currentSymbol == "{")
                {
                    parantheses.Push(currentSymbol);

                }
                else if(currentSymbol == "[")
                {
                    parantheses.Push(currentSymbol);

                }

                if(parantheses.Count <= 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                if(currentSymbol == ")")
                {
                    string lastTimePushedSymbol = parantheses.Pop();
                    if(lastTimePushedSymbol != "(")
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if(currentSymbol == "}")
                {
                    string lastTimePushedSymbol = parantheses.Pop();
                    if(lastTimePushedSymbol != "{")
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (currentSymbol == "]")
                {
                    string lastTimePushedSymbol = parantheses.Pop();
                    if (lastTimePushedSymbol != "[")
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }
            if(parantheses.Count > 0)
            {
                Console.WriteLine("NO");
                
            }
            else
            {

                Console.WriteLine("YES");
            }

            //parentheses: (, {, and [.




        }
    }
}
