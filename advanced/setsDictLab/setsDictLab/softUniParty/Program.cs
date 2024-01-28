namespace softUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty ;
            HashSet<string> guests = new HashSet<string>();
            bool isParty = false;
            while((input = Console.ReadLine()) != "END")
            {
                string guestOrCommand = input;
                if(guestOrCommand == "PARTY")
                {
                    isParty = true;
                }
                if (isParty)
                {
                    guests.Remove(guestOrCommand);
                }
                else
                {
                    guests.Add(guestOrCommand);
                }
                
            }

            List<string> vip = new List<string>();
            List<string> nonVip = new List<string>();
            foreach (var guest in guests)
            {
                char firstDigit = guest[0];
                if (char.IsDigit(firstDigit))
                {
                    vip.Add(guest);
                }
                else
                {
                    nonVip.Add(guest);
                }
            }

            Console.WriteLine(guests.Count);
            foreach (var g in vip)
            {
                Console.WriteLine(g);
            }
            foreach (var g in nonVip)
            {
                Console.WriteLine(g);
            }

        }
    }
}
