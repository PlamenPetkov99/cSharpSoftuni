namespace cardsGame
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < playerOneDeck.Count; i++)
            {
                if(playerOneDeck.Count <= 0 || playerTwoDeck.Count <= 0)
                {
                    break;
                }
                if (playerOneDeck[i] > playerTwoDeck[i]) // if playerOne win round
                {
                    int currentCard = playerOneDeck[i]; // get winning card
                    playerOneDeck.Add(playerTwoDeck[i]); // losing card goes last
                    playerOneDeck.Add(currentCard); // winning card goes behind losing card
                    playerOneDeck.RemoveAt(i);//removing winning card from front
                    playerTwoDeck.RemoveAt(i);//removing losing card from losing deck


                }
                else if (playerOneDeck[i] == playerTwoDeck[i])
                {
                    playerOneDeck.RemoveAt(i);
                    playerTwoDeck.RemoveAt(i);
                }
                else // if playerTwo win round
                {
                    int currentCard = playerTwoDeck[i]; // get winning card
                    playerTwoDeck.Add(playerOneDeck[i]); // losing card goes last
                    playerTwoDeck.Add(currentCard); // winning card goes behind losing card
                    playerTwoDeck.RemoveAt(i);//removing winning card from front
                    playerOneDeck.RemoveAt(i);//removing losing card from losing deck

                }
                i = -1 ;
                
                
                //playerOneDeck [i] == playerTwoDeck[i] 
                // mahame kartata i ot dvata playera


            }

            if(playerTwoDeck.Count < playerOneDeck.Count)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneDeck.Sum()}");
                //playerOneWIN
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoDeck.Sum()}");
                //playerTwoWIN
            }


        }
    }
}