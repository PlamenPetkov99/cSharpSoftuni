namespace simpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> states = new Stack<string>();
            string text = "";
            states.Push(text);

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split().ToArray(); //"CommandName Argument"
                string command = inputTokens[0];

                if(command == "1")
                {
                    string wordToAppend = inputTokens[1];
                    string lastState = states.Peek();
                    lastState = lastState + wordToAppend;
                    states.Push(lastState);

                }
                else if(command == "2")
                {
                    int countToRemoveAtEnd = int.Parse(inputTokens[1]);
                    string lastState = states.Peek();
                    List<char> lastStateCharList = lastState.ToList();
                    for (int j = 0; j < countToRemoveAtEnd; j++)
                    {
                        lastStateCharList.RemoveAt(lastStateCharList.Count - 1);
                    }
                    string currentResult = new string(lastStateCharList.ToArray());
                    states.Push(currentResult);

                }
                else if(command == "3")
                {
                    int index = int.Parse(inputTokens[1]);
                    string lastState = states.Peek();
                    Console.WriteLine(lastState[index-1]);


                }
                else if(command == "4")
                {
                    states.Pop();
                }

            }


        }
    }
}
