namespace ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> constests = new Dictionary<string, string>();
            List<User> users = new List<User>();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "end of contests")
            {
                //{contest}:{password for contest}
                string[] inputTokens = line.Split(":").ToArray();
                string contest = inputTokens[0];
                string passowrd = inputTokens[1];

                constests[contest] = passowrd;

            }

            string inputline = string.Empty;
            while ((inputline = Console.ReadLine()) != "end of submissions")
            {
                //{contest}=>{password}=>{username}=>{points}
                string[] inputTokens = inputline.Split("=>").ToArray();

                string currentContest = inputTokens[0];
                string currentPassword = inputTokens[1];
                string username = inputTokens[2];
                int points = int.Parse(inputTokens[3]);

                if (constests.ContainsKey(currentContest))
                {
                    if (constests[currentContest] == currentPassword)
                    {
                        User isUserFound = users.Find(x => x.ConstestPassword.ContainsKey(currentContest));

                        if(isUserFound == null)
                        {
                            User user = new User(username);
                            user.ConstestPassword[currentContest] = points;
                            users.Add(user);
                        }
                    }
                }

            }

        }
    }

    public class User
    {
        public string Name { get; set; }
        public Dictionary<string, int> ConstestPassword { get; set; }

        public User(string name)
        {
            Name = name;
            ConstestPassword = new Dictionary<string, int>();
        }

    }
}
