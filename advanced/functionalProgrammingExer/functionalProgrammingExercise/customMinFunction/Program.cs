namespace customMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> customMin = array =>
            {
                int min = int.MaxValue;
                foreach (int number in array)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }

                return min;
            };

            Console.WriteLine(customMin(numbers));


        }
    }
}
