namespace stackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++) //we put numbers array in stack with exact order
            {
                int currentNum = numbers[i];
                stackNumbers.Push(currentNum);
            }

            
            string input = string.Empty;
            while((input = Console.ReadLine().ToLower()) != "end")//o	Add <n1> <n2> , o	Remove <n>: 
            {
                string[] inputTokens = input.Split().ToArray();
                string command = inputTokens[0];
                

                if(command == "add")
                {
                    int firstNumber = int.Parse(inputTokens[1]);
                    int secondNumber = int.Parse(inputTokens[2]);
                    stackNumbers.Push(firstNumber);
                    stackNumbers.Push(secondNumber);
                }
                else if(command == "remove")
                {
                    int countNumbersToRemove = int.Parse(inputTokens[1]);
                    if(countNumbersToRemove > stackNumbers.Count)
                    {
                        continue;
                    }
                    for(int i = 0; i < countNumbersToRemove; i++)
                    {
                        stackNumbers.Pop();
                    }
                    
                }


            }

            int totalSum = 0;
            int countOjects = stackNumbers.Count;
            for (int i = 0; i < countOjects; i++)
            {
                int currentNumber = stackNumbers.Pop();
                totalSum += currentNumber;
            }
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
