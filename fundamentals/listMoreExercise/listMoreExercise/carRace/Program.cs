namespace carRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] raceLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double firstRacerTime = 0;
            double secondRacerTime = 0;

            int finishIndex = (raceLine.Length - 1) / 2;

            for (int i = 0; i < finishIndex; i++) // firstRacer
            {
                int currentTime = raceLine[i];
                if(currentTime == 0)
                {
                    firstRacerTime = firstRacerTime - (firstRacerTime * 0.20);
                    continue;
                }
                
                firstRacerTime += currentTime;

            }
            for (int i = raceLine.Length - 1; i > finishIndex; i--) // secondRacer
            {
                int currentTime = raceLine[i];
                if (currentTime == 0)
                {
                    secondRacerTime = secondRacerTime - (secondRacerTime * 0.20);
                    continue;
                }

                secondRacerTime += currentTime;

            }

            if(firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime,0}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }

        }
    }
}
