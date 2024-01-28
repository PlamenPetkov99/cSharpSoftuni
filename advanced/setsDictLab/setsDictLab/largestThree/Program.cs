namespace largestThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sorted = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] sortedArray = sorted.ToArray();
            sortedArray = sortedArray.OrderByDescending(x=>x).ToArray();

            int numbersToPrint = Math.Min(3,sortedArray.Length);

            for (int i = 0; i < numbersToPrint; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
        }
    }
}
