namespace songsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string>songs = new Queue<string>();
            string[] songsArray = Console.ReadLine().Split(", ").ToArray();

            foreach(string song in songsArray)
            {
                songs.Enqueue(song);
            }

            
            while(songs.Count > 0)
            {
                string inputLine = Console.ReadLine();
                string[] inputTokens = inputLine.Split().ToArray();
                string command = inputTokens[0];

                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    string songToAdd = inputLine.Substring(4);
                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }

                }
                else if (command == "Show")//, 
                {
                    Console.WriteLine(string.Join(", ",songs));
                }

                
            }
            Console.WriteLine("No more songs!");



        }
    }
}
