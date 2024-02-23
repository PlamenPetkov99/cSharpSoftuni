namespace reverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int ConditionN = int.Parse(Console.ReadLine());

            Func<int[], int[]> reverseIt = array =>
            {
                int[] reversedArray = new int[array.Length];
                Stack<int> tempStack = new Stack<int>(array);
                reversedArray = tempStack.ToArray();
                return reversedArray;
            };

            int[] reversedArray = reverseIt(numbers);
            List<int> reversedList = reversedArray.ToList();

            Predicate<int> predicate = num => num % ConditionN == 0;

            //List<int> numbersForRemove = reversedList.Where(num => predicate(num)).ToList();

            reversedList.RemoveAll(predicate);
            Console.WriteLine(string.Join(" ",reversedList));

        }
    }
}
