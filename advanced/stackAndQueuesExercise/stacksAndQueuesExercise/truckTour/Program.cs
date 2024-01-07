namespace truckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<long>values = new List<long>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split().ToArray();
                long amountPetrol = long.Parse(inputTokens[0]);
                long distance = long.Parse(inputTokens[1]);
                long result = amountPetrol - distance;
                

                    values.Add(result);
                
            }

            long bestOption = values.Max();
            int indexOfBestOption = values.IndexOf(bestOption);
            Console.WriteLine(indexOfBestOption);


        }
    }
}
