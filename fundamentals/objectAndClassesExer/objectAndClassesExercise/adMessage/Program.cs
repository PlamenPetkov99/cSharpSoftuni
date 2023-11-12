namespace adMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Ad ad = new Ad();
            ad.Phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            ad.Events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            ad.Authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            ad.Cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomIndexPhrase = random.Next(ad.Phrases.Count);
                int randomIndexEvents = random.Next(ad.Events.Count);
                int randomIndexAuthors = random.Next(ad.Authors.Count);
                int randomIndexCities = random.Next(ad.Cities.Count);

                Console.WriteLine($"{ad.Phrases[randomIndexPhrase]} {ad.Events[randomIndexEvents]} {ad.Authors[randomIndexAuthors]} – {ad.Cities[randomIndexCities]}.");

            }

            


        }
    }
    class Ad
    {
        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }
        
        


    }
}