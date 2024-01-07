namespace basicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countElementsToPush = nSX[0];
            int countElementsToPop = nSX[1];
            int elementToSearchFor = nSX[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>();

            foreach (int number in numbers)
            {
                numbersStack.Push(number);
            }

            int numbersToRemove = Math.Min(numbersStack.Count, countElementsToPop);

            for (int i = 0; i < numbersToRemove; i++)
            {
                numbersStack.Pop();
            }

            if(numbersStack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (numbersStack.Contains(elementToSearchFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersStack.Min());
            }


        }
    }
}
