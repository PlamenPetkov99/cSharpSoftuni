namespace countSameValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double , int> counter = new Dictionary<double , int>();


            foreach(double number in numbers)
            {
                if (counter.ContainsKey(number))
                {
                    counter[number]++;
                }
                else
                {
                    counter[number] = 1;
                }

            }

            //3 - 4 times

            foreach(KeyValuePair<double,int> kvp in counter)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }



        }
    }
}
