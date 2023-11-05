namespace songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> playlist = new List<Song>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Song song = new Song();
                string[] input = Console.ReadLine().Split("_").ToArray();
                song.type = input[0];
                song.name = input[1];
                song.time = input[2];
                playlist.Add(song);

                
            }
            string filter = Console.ReadLine();

            foreach (Song song in playlist)
            {
                if(filter == "all")
                {
                    Console.WriteLine(song.name);
                }
                else if(filter == song.type)
                {
                    Console.WriteLine(song.name);
                }
            }

        }

        public class Song
        {
            public  string type { get; set; }
            public  string name { get; set; }
            public  string time { get; set; }
        }
    }
}