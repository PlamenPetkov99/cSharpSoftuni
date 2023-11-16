namespace countRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (sortedDict.ContainsKey(currentNumber))
                {
                    sortedDict[currentNumber]++;
                }
                else
                {
                    sortedDict[currentNumber] = 1;
                }
            }

            foreach (KeyValuePair<int,int> kvp in sortedDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}