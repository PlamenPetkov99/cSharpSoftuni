namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagoons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagoonCapacity = int.Parse(Console.ReadLine());

            string input = "";
            while((input = Console.ReadLine()) != "end")
            {
                string[] commandAndValues = input.Split();
                
                if(commandAndValues.Length > 1)
                {
                    int passengersInNewWagoon = int.Parse(commandAndValues[1]);
                    wagoons.Insert(wagoons.Count, passengersInNewWagoon);
                }
                else
                {
                    int passengers = int.Parse(commandAndValues[0]);
                    for (int i = 0; i < wagoons.Count; i++)
                    {
                        int currentWagoonCapacity = wagoons[i];
                        int neededSpace = currentWagoonCapacity + passengers;
                        if(neededSpace <= maxWagoonCapacity)
                        {
                            wagoons[i] = neededSpace;
                            break;
                        }

                    }

                }
            }

            Console.WriteLine(string.Join(" ",wagoons));


        }
    }
}