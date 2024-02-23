namespace partyReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            //List<Func<string, bool>> listOfPredicates = new List<Func<string, bool>>();
            Dictionary<string, List<string>> typePara = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "Print") //Add filter;Starts with;P
            {
                string[] inputTokens = input.Split(';').ToArray();
                string command = inputTokens[0];
                string type = inputTokens[1];
                string parameter = inputTokens[2];


                if (command == "Add filter")
                {
                    //listOfPredicates.Add(predicate);
                    if (!typePara.ContainsKey(type))
                    {
                        typePara[type] = new List<string>();
                        typePara[type].Add(parameter);
                    }
                    else
                    {
                        typePara[type].Add(parameter);
                    }
                }
                else if (command == "Remove filter")
                {
                    //listOfPredicates.Remove(predicate);
                    typePara[type].Remove(parameter);
                }
            }


            foreach (var kvp in typePara)
            {
                foreach (string parameter in kvp.Value)
                {
                    Func<string, bool> predicate = CreatePredicate(kvp.Key, parameter);
                    invitations.RemoveAll(inv => predicate(inv));
                }
            }

            Console.WriteLine(string.Join(' ',invitations));

        }

        private static Func<string, bool> CreatePredicate(string type, string parameter)
        {

            if (type == "Starts with")
            {
                return invite => invite.StartsWith(parameter);
            }
            else if (type == "Length")
            {
                return invite => invite.Length == int.Parse(parameter);
            }
            else if (type == "Ends with")
            {
                return invite => invite.EndsWith(parameter);
            }

            return invite => invite.Contains(parameter);

        }
    }
}
