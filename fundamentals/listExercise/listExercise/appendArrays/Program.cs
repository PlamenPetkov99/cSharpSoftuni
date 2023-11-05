namespace appendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bigArray = Console.ReadLine().Split('|' , StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();

            for (int i = bigArray.Count - 1; i >= 0; i--)
            {
                string[] currentArray = bigArray[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                result.AddRange(currentArray);
                
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}