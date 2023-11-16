namespace softUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string,string> nameAndLicense = new Dictionary<string,string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                //"register {username} {licensePlateNumber}"
                //"unregister {username}"
                string[] inputTokens = Console.ReadLine().Split().ToArray();
                string command = inputTokens[0];
                string username = inputTokens[1];

                if(command == "register")
                {
                    string licensePlate = inputTokens[2];
                    if (nameAndLicense.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {nameAndLicense[username]}");
                        continue;
                    }

                    nameAndLicense[username] = licensePlate;
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
                else if(command == "unregister")
                {
                    
                    if (!nameAndLicense.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    nameAndLicense.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }

            }

            foreach (KeyValuePair<string,string> kvp in nameAndLicense)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }



            //Print "{username} => {licensePlateNumber}"
        }
    }
}