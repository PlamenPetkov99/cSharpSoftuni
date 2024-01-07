namespace basicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countElementsToEnqueue = nSX[0];
            int countElementsToDequeue = nSX[1];
            int elementToSearchFor = nSX[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbersStack = new Queue<int>();

            foreach (int number in numbers)
            {
                numbersStack.Enqueue(number);
            }

            int numbersToRemove = Math.Min(numbersStack.Count, countElementsToDequeue);

            for (int i = 0; i < numbersToRemove; i++)
            {
                numbersStack.Dequeue();
            }

            if (numbersStack.Count <= 0)
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
