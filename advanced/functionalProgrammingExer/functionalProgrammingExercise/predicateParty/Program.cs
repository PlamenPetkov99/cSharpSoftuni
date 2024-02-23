using System.IO;

namespace predicateParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();


            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = inputTokens[0];
                string criteria = inputTokens[1];//StartsWith , Length , EndsWith
                string parameter = inputTokens[2];
                Func<string, bool> predicate = CreateFilter(criteria, parameter);
                if (command == "Remove")
                {
                    guests.RemoveAll(x => predicate(x));
                }
                else//double
                {
                    List<string> guestsToDouble = guests.Where(x => predicate(x)).ToList();
                    foreach (string g in guestsToDouble)
                    {
                        int index = guests.IndexOf(g);
                        if(index + 1 != guests.Count) 
                        {
                            guests.Insert(index+1,g);
                        }
                        else
                        {
                            guests.Add(g);
                        }
                        
                    }
                }

            }

            if (guests.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.Write(string.Join(", ",guests));
                Console.Write(" are going to the party!");
            }

        }
        private static Func<string, bool> CreateFilter(string criteria, string parameter)
        {
            if (criteria == "StartsWith")
            {
                return guest => guest.StartsWith(parameter);
            }
            else if (criteria == "Length")
            {
                return guest => guest.Length == int.Parse(parameter);
            }

            return guest => guest.EndsWith(parameter);



        }
    }
}
